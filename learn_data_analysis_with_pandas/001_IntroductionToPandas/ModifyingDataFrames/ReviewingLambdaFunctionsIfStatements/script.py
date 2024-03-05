# lambda x: [OUTCOME IF TRUE] if [CONDITIONAL] else [OUTCOME IF FALSE]
mylambda = lambda x: 'Welcome to BattleCity!' \
  if x >= 13 \
  else 'You must be 13 or older'

print(mylambda(13))
print(mylambda(12))
