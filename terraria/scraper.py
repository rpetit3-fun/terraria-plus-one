#! /usr/bin/env python
""" HTML parsing functions used by Terraria Tools. """
import urllib2
from bs4 import BeautifulSoup


class Scraper(object):

    def __init__(self):
        self.header = {
            'User-Agent': ('Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.11'
                           ' (KHTML, like Gecko) Chrome/23.0.1271.64 '
                           'Safari/537.11'),
            'Accept': ('text/html,application/xhtml+xml,application/xml;'
                       'q=0.9,*/*;q=0.8'),
            'Accept-Charset': 'ISO-8859-1,utf-8;q=0.7,*;q=0.3',
            'Accept-Encoding': 'none',
            'Accept-Language': 'en-US,en;q=0.8',
            'Connection': 'keep-alive'
        }

    def cook_soup(self, url):
        """ Scrape HTML from a given URL. """
        request = urllib2.Request(url, headers=self.header)
        html = urllib2.urlopen(request).read()
        return BeautifulSoup(html, 'lxml')
