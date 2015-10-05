#! /usr/bin/env python
""" Terraria related functions. """
from collections import OrderedDict

import scraper


class Weapons(object):

    def __init__(self):
        self.scraper = scraper.Scraper()
        self.sword_fields = ['title', 'item_id', 'damage', 'damage_type',
                             'delay', 'knockback', 'auto_swing', 'rarity',
                             'sell_price']

    def __init_melee_weapon(self):
        return OrderedDict((
            ('title', None), ('item_id', None), ('damage', None),
            ('damage_type', None), ('delay', None), ('knockback', None),
            ('auto_swing', None), ('rarity', None), ('sell_price', None)
        ))

    def get_swords(self):
        """ Return a list of Terraria Swords. """
        from urls import SWORDS
        self.swords = []
        soup = self.scraper.cook_soup(SWORDS)
        for row in soup.findAll('tr'):
            td = row.findAll('td')
            if len(td) == 9:
                try:
                    sword = self.__init_melee_weapon()
                    sword['title'] = td[0].find('a')['title']
                    sword['damage'] = td[2].find('b').text.split(' ')[0]
                    sword['damage_type'] = td[3].text.strip()
                    sword['delay'] = td[4].text.lstrip().split(' ')[0]
                    sword['knockback'] = td[5].text.lstrip().split(' ')[0]
                    sword['rarity'] = td[7].find('img')['alt'].replace(
                        'Rarity Level: ', ''
                    )
                    sword['sell_price'] = str(sum(
                        [int(i['data-info']) for i in td[8].findAll('span')]
                    ))

                    item_id = td[1].find('div').text.replace(
                        'Internal Item ID: ', ''
                    )

                    # Its Phaseblade or Phasesaber (multiple item_ids)
                    if '-' in item_id:
                        sword['auto_swing'] = '1'
                        for i in xrange(198, 204):
                            sword['item_id'] = str(i)
                            self.swords.append(sword.copy())
                    else:
                        sword['item_id'] = item_id
                        if 'Tick1.png' in td[6].find('img')['alt']:
                            sword['auto_swing'] = '1'
                        else:
                            sword['auto_swing'] = '0'
                        self.swords.append(sword)
                except AttributeError:
                    continue

    def sword_fields(self):
        return
