first_name = "Reiko"
last_name = "Matsuki"

def password_generator(first_name, last_name):
  pw = first_name[len(first_name)-3:] + last_name[len(last_name)-3:]
  return pw

temp_password = password_generator(first_name, last_name)
print(temp_password)