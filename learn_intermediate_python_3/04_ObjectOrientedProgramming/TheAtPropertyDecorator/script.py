class Box():
    def __init__(self, weight):
        self.__weight = weight

    @property
    def weight(self):
        """Docstring for the 'weight' property"""
        return self.__weight
    
    @weight.setter
    def weight(self, weight):
        if weight >= 0:
            self.__weight = weight

    @weight.deleter
    def weight(self):
        del self.__weight

# Testing getter
box = Box(5)
print(box.weight)

# Testing setter
box.weight = -1
print(box.weight)
box.weight = 6
print(box.weight)

# Testing deleter.
del box.weight
print(box.weight)
