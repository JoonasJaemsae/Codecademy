class Business:
  def __init__(self, name, franchises):
    self.name = name
    self.franchises = franchises

class Franchise:
  def __init__(self, address, menus):
    self.address = address
    self.menus = menus

  def __repr__(self):
    return "The restaurant's address is {}".format(self.address)

  def available_menus(self, time):
    available_menus = []
    for menu in self.menus:
      if (menu.start_time <= time and menu.end_time >= time):
        available_menus.append(menu)
    return available_menus

class Menu:
  def __init__(self, name, items, start_time, end_time):
    self.name = name
    self.items = items
    self.start_time = start_time
    self.end_time = end_time

  def __repr__(self):
    return "{} menu available from {} to {}".format(self.name, self.start_time, self.end_time)

  def calculate_bill(self, purchased_items):
    total = 0
    for price in purchased_items.values():
      total += price
    return total

brunch_items = {
  'pancakes': 7.50, 'waffles': 9.00, 'burger': 11.00, 'home fries': 4.50, 'coffee': 1.50, 'espresso': 3.00, 'tea': 1.00, 'mimosa': 10.50, 'orange juice': 3.50
}
brunch = Menu("Brunch", brunch_items, 1100, 1600)
print(brunch)

early_bird_items = {
  'salumeria plate': 8.00, 'salad and breadsticks (serves 2, no refills)': 14.00, 'pizza with quattro formaggi': 9.00, 'duck ragu': 17.50, 'mushroom ravioli (vegan)': 13.50, 'coffee': 1.50, 'espresso': 3.00,
}
early_bird = Menu("Early Bird", early_bird_items, 1500, 1800)
print(early_bird)

dinner_items = {
  'crostini with eggplant caponata': 13.00, 'caesar salad': 16.00, 'pizza with quattro formaggi': 11.00, 'duck ragu': 19.50, 'mushroom ravioli (vegan)': 13.50, 'coffee': 2.00, 'espresso': 3.00,
}
dinner = Menu("Dinner", dinner_items, 1700, 2300)
print(dinner)

kids_items = {
  'chicken nuggets': 6.50, 'fusilli with wild mushrooms': 12.00, 'apple juice': 3.00
}
kids = Menu("Kids", kids_items, 1100, 2100)
print(kids)

arepa_items = {
  'arepa pabellon': 7.00, 'pernil arepa': 8.50, 'guayanes arepa': 8.00, 'jamon arepa': 7.50
}
arepas_menu = Menu("Take a' Arepa", arepa_items, 1000, 2000)
print(arepas_menu)

breakfast_order = {'pancakes': 7.50, 'home fries': 4.50, 'coffee': 1.50}
early_bird_order = {'salumeria plate': 8.00, 'mushroom ravioli (vegan)': 13.50,}
print(brunch.calculate_bill(breakfast_order))
print(early_bird.calculate_bill(early_bird_order))

menus_1 = [brunch, early_bird, dinner, kids]
menus_2 = [arepas_menu]
address_1 = "1232 West End Road"
address_2 = "12 East Mulberry Street"
address_3 = "189 Fitzgerald Avenue"
flagship_store = Franchise(address_1, menus_1)
new_installment = Franchise(address_2, menus_1)
arepas_place = Franchise(address_3, menus_2)

print(flagship_store)
print(new_installment)
print(arepas_place)
print(flagship_store.available_menus(1700))
print(arepas_place.available_menus(1500))
business_1 = Business("Basta Fazoolin' with my Heart", [flagship_store, new_installment])
business_2 = Business("Take a' Arepa", [arepas_place])