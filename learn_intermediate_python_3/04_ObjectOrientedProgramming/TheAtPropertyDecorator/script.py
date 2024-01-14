class Box():
    def __init__(self, weight):
        self.__weight = weight

    @property
    def weight(self):
        """Docstring for the 'weight' property"""
        return self.__weight

box = Box(5)
print(box.weight)