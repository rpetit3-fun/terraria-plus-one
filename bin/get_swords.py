#! /usr/local/bin python
from terraria import weapons

w = weapons.Weapons()
w.get_swords()
w.swords[0]['title']

print ','.join(w.sword_fields)
for sword in w.swords:
    print ','.join([sword[field] for field in w.sword_fields])
