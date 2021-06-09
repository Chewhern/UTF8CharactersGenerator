# UTF8CharactersGenerator
A simple application to brute force all possible unicode characters and stores them into file in Base64 Encoding Format

When people talk about random password generation, it's quite lame to only able to generate them in ASCII format,
but generating a unicode password is hard, it consists of 3 steps:
1. Brute forcing all possible unicode characters on any os any desktop devices and stores them in base64 format
(there's a reason why storing in base64 format is good)
2. Filtering the generated unicode that is in base64 format
3. Take the filtered unicode(lists) and use them to generate unicode password


This application is the <b>first</b> step in generating random unicode password
