class Employee():
    def __init__(self):
        self.id = None
        # Write your code below
        self._id = 42
        self.__id = 108

e = Employee()
print(dir(e))