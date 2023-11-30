word = "Mississippi"
letter = "i"

def letter_check(word, letter):
  for character in word:
    if character == letter:
      return True
  return False

print(letter_check(word, letter))