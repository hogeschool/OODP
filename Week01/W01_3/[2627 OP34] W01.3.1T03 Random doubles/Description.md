Learning goals:
- random doubles

Keep attacking the boss by subtracting `attack` from `bossHP` until the `bossHP` is 0 or less. Each attack has a chance of being a critical hit, meaning the damage will be doubled for that attack.

Since random integers will not be sufficient for simulating outcomes of events with probabilities, you MUST use `NextDouble` of the `Random` class for this assignment. You do not have to provide it with a seed this time.

The output could (depending on the randomly occurring critical hits) look like this:
```
Boss HP: 1000
Damage: 50

Boss HP: 950
Damage: 100

Boss HP: 850
Damage: 50

...

Boss HP: 200
Damage: 50

Boss HP: 150
Damage: 50

Boss HP: 100
Damage: 100

Boss defeated
```