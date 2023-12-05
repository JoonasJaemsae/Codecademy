# Write your code below: 
def single_prix_fixe_order(appetizer, *entrees, sides, **dessert_scoops):
  print(appetizer)
  print(entrees)
  print(sides)
  print(dessert_scoops)

# kwargs need to be keyword arguments! (below: dessert_1, dessert_2)
single_prix_fixe_order('Baby Beets', 'Salmon', 'Scallops', sides='Mashed Potatoes', dessert_1='Vanilla', dessert_2='Cookies and Cream')