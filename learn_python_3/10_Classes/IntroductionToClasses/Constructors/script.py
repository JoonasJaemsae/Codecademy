class Circle:
  pi = 3.14
  
  # Add constructor here:
  def __init__(self, diameter):
    if type(diameter) == int:
      print("New circle with diameter: {}".format(diameter))

teaching_table = Circle(36)