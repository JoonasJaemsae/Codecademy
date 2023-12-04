class Student:
  def __init__(self, name, year):
    self.name = name
    self.year = year
    self.grades = []

  def add_grade(self, grade):
    if type(grade) == Grade:
      self.grades.append(grade)

class Grade:
  minimum_passing = 65

  def __init__(self, score):
    self.score = score
  
  def __repr__(self):
    return str(self.score)

roger = Student("Roger van der Weyden", 10)
sandro = Student("Sandro Botticelli", 12)
pieter = Student("Pieter Bruegel the Elder", 8)

new_grade_1 = Grade(100)
new_grade_2 = Grade(80)
pieter.add_grade(new_grade_1)
pieter.add_grade(new_grade_2)
print(pieter.grades)