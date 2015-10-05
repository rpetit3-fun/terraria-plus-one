#! /usr/bin/env python
import argparse as ap
import shutil
from string import Template


def add_stations(station):
    station = station.replace('"', '')
    stations = []
    for s in station.split(','):

        add = 'recipe.AddTile(TileID.{0});'.format(s)
        if stations:
            stations.append('            ' + add)
        else:
            stations.append(add)

    return '\n'.join(stations)


def add_ingredients(recipe):
    recipe = recipe.replace('"', '')
    ingredients = []
    for ingredient in recipe.split(','):
        quantity, item = ingredient.split(':')
        add = ''
        if 'PlusOne' in ingredient:
            add = 'recipe.AddIngredient(null, "{0}", {1});'.format(
                item,
                quantity
            )
        else:
            add = 'recipe.AddIngredient(Terraria.ID.ItemID.{0}, {1});'.format(
                item,
                quantity
            )
        if ingredients:
            ingredients.append('            ' + add)
        else:
            ingredients.append(add)

    return '\n'.join(ingredients)


if __name__ == '__main__':
    parser = ap.ArgumentParser(
        prog='write_weapons.py', conflict_handler='resolve',
        description="Create weapon templates for Terraria +1"
    )

    parser.add_argument('input', metavar='INPUT',
                        help='Input tab delimited file of wepons to produce.')
    parser.add_argument('template', metavar='WEAPON_TEMPALTE',
                        help=('Python String Template file to produce C# code '
                              'for modified weapons.'))
    parser.add_argument('modname', metavar='MODNAME',
                        help=('name of the Mod.'))
    parser.add_argument('images', metavar='IMAGE_DIR',
                        help=('Directory where images for modified weapons '
                              'can be found.'))
    parser.add_argument('output', metavar='OUTPUT_DIR',
                        help=('Directory to output generated scripts to.'))

    args = parser.parse_args()

    # Read the template
    template = Template(open(args.template, 'r').read())

    with open(args.input, 'r') as fh:
        first_line = True
        col_names = None
        for line in fh:
            line = line.rstrip()
            if first_line:
                col_names = line.split('\t')
                first_line = False
            else:
                weapon = dict(zip(col_names, line.split('\t')))
                weapon['modname'] = args.modname
                weapon['ingredients'] = add_ingredients(weapon['recipe'])
                weapon['stations'] = add_stations(weapon['station'])

                # Write Tempalte to file
                out = '{0}/{1}.cs'.format(args.output, weapon['class'])
                with open(out, 'w') as fh_out:
                    fh_out.write(template.substitute(weapon))

                # Copy image
                src = '{0}/Item_{1}.png'.format(args.images, weapon['item_id'])
                dest = '{0}/{1}.png'.format(args.output, weapon['class'])
                shutil.copyfile(src, dest)
