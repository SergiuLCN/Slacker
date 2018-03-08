# Slacker
Financial, dietary and fitness tracker.

The Project is divided in the tools mentioned above.

################################################################################################################################

Progress so far:

-changed the layout style
-added a cover image
-added a multifunctional button in the cover that dinamically changes text and functions according to different cases
-added a dinamic main menu composed of "link tiles" that highlight when mouse-hovered and fades in and out sequentially with the 
press of the cover button 
-added financial tracker module{
                              -created model,controllers, views
                              -input forms(amount, sign, source)
                              -input source autocomplete and scroll
                              -input forms grouped with the records display list{
                                                                                 -formatted the list
                                                                                 -added :even / :odd row color
                                                                                 }
################################################################################################################################                                                                     

To do list:

Financial tracker module:
-add edit view into the financial tracker view as partial; this would mean that a list and the form data have to be passed into the
view
-modify the financial tracker forms group in order to stop scrolling when it meets the bottom of the table
-add multiple currencies using a financial api; a change in display would be preffered, while the main currency(and the one in the database) would be $
-add more functions, as vault, total balance
 
Dietary tracker module:
-to be added
 
Fitness tracker module:
-to be added
 
Users:
-implement the authorizations for users
                              
