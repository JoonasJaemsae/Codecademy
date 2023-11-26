import random

name = "Joe"
question = "Is this course a little too easy for my level?"
answer = ""

random_number = random.randint(1, 9)
ans_1 = "Yes - definitely"
ans_2 = "It is decidedly so"
ans_3 = "Without a doubt"
ans_4 = "Reply hazy, try again"
ans_5 = "Ask again later"
ans_6 = "Better not tell you now"
ans_7 = "My sources say no"
ans_8 = "Outlook not so good"
ans_9 = "Very doubtful"

if question == "":
  question = "Can the question field be left empty?"

if name == "":
  print("Question: " + question)
else:
  print(name + " asks: " + question)

if random_number == 1:
  print("Magic 8-Ball's answer: " + ans_1)
elif random_number == 2:
  print("Magic 8-Ball's answer: " + ans_2)
elif random_number == 3:
  print("Magic 8-Ball's answer: " + ans_3)
elif random_number == 4:
  print("Magic 8-Ball's answer: " + ans_4)
elif random_number == 5:
  print("Magic 8-Ball's answer: " + ans_5)
elif random_number == 6:
  print("Magic 8-Ball's answer: " + ans_6)
elif random_number == 7:
  print("Magic 8-Ball's answer: " + ans_7)
elif random_number == 8:
  print("Magic 8-Ball's answer: " + ans_8)
elif random_number == 9:
  print("Magic 8-Ball's answer: " + ans_9)
else:
  print("Error")