class School():
  def __init__(self, name, level, numberOfStudents):
    self._name = name
    self._level = level
    self._numberOfStudents = numberOfStudents

  def get_name(self):
      return self._name

  def get_level(self):
      return self._level

  def get_numberOfStudents(self):
      return self._numberOfStudents

  def set_numberOfStudents(self, numberOfStudents):
      self._numberOfStudents = numberOfStudents

  def __repr__(self):
    return "A {} school named {} with {} students.".format(self._level, self._name, self._numberOfStudents)

class PrimarySchool(School):
  def __init__(self, name, numberOfStudents, pickupPolicy):
    super().__init__(name, "primary", numberOfStudents)
    self._pickupPolicy = pickupPolicy
  
  def get_pickupPolicy(self):
      return self._pickupPolicy

  def __repr__(self):
    return super().__repr__() + " {}.".format(self._pickupPolicy)

class HighSchool(School):
  def __init__(self, name, numberOfStudents, sportsTeams):
    super().__init__(name, "high", numberOfStudents)
    self._sportsTeams = sportsTeams

  def get_sportsTeams(self):
    return self._sportsTeams

  def __repr__(self):
    return super().__repr__() + " Sports teams include {}.".format(", ".join(self._sportsTeams))

school = School("Hogwarts", "middle", 300)
p_school = PrimarySchool("Hive Helsinki", 100, "Pickup after 3pm")
h_school = HighSchool("Roke Island High", 500, ["Gont Sparrowhawks", "Kargo Creepers", "Selidor Mighty Dragons"])
print(school)
print(school.get_name())
print(school.get_level())
print(school.get_numberOfStudents())
school.set_numberOfStudents(200)
print(school.get_numberOfStudents())
print("------")

print(p_school)
print(p_school.get_pickupPolicy())
print("------")

print(h_school)
print(h_school.get_sportsTeams())
