# Electronic-Point-Of-Sale
This is my Electronic Point of Sale software that is made in the language Visual Basic. It was an idea I was floating around for my Year 13 coursework but I decided to do it in my spare time.

# Usage
When you boot up the till you will be presented with a few message boxes initializing everything. This is creating the necessary files for the program to work.

There will be 2 files created inside a folder named EPOS Resources, they are named:
- index.page
- products.prod

### Index.page
Index.page is sort of like the index.html file when you are creating in web development, it is the main file that the program goes to. The index.page is a caret separated document, and the syntax goes as follows:


    item^1
    item^2
    item^3
    item^3
    item^1
    item^2
    item^3
    item^4
    item^5
If you are unaware, the syntax goes:

`[Item/Folder/Page]^[Product line number/Folder]`

It is created so you can have multiple pages (added in commit 4) and move between them seamlessly in a slide. The folders and pages are not yet implemented at this time but there is minimal support so they will be recognised in code.

### Products.prod
The products.prod file is also a caret separated document but unlike the Index.page file, there is only one of them and the program refers to it when looking up every single item that it has on offer. It is used largely in conjunction because the line number that the product is on is it's ID.


    Burger^1.50^images/Burger.png
    Sausage Roll^.85^images/Sausage Roll.png
    Corned Beef Pasty^1.65^images/Corned Beef Pasty.png
If you aware unaware, the syntax goes:

`[Name of item]^[Price]^[Reference to image]`

