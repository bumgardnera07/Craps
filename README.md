# Craps
A simplified Craps game in Windows.Forms

## How do I play it?

The release version of the app is here: \Craps\Craps\bin\Release.
Run Craps.Exe to boot up the program.

If you want to load the whole solution file into Visual Studio, you can view Unit Tests and Database scripts attached to the solution.

## How was it built?

The project was set up entirely in Windows forms. This includes a SQLLocalDB MDF file which will create a small database to store the game data. This data will persist across sessions, i.e. the same user can log in after the game has been closed.

## Craps Rules

In standard Craps, the player has two standard dice, each with six faces, numbered 1 through 6. The player will roll both dice at the same time, landing on a random side. If the sum of both dice is 7 or 11 on the first roll, the player wins. If the sum of both dice is 2, 3, or 12 on the first roll, then ‘Craps’ is the result, and the player loses.

If the sum of both dice is 4, 5, 6, 8, 9, or 10 on the first roll 
then that sum becomes the player’s “point”. Once the point has been set, then the rules of the game change. If at any time after the first roll, a 7 is rolled, the player loses and the point is reset. If the player rolls the point, then the player wins. Hitting the point also resets
the point. When the point is reset, the game starts over, and the next roll of the dice acts like the first roll of the dice again.

## Data

The following data is stored in the database:
USER Table: The player’s ID and Name
GAME Table: Game ID , Point(if set), Win/Lose/Null result, Game Time, Player ID
ROLL Table: Roll ID, Game Number, Die1 Roll, Die2 Roll, Point (if set), Roll Number, Player Id 
-Roll Number here is the sequence of the roll within the context of the current game
ROLLHIST Table: This is a join table for rolls and games that allows us to review a history of rolls across games. We filter it with the Id of the current Player.

## Player can:
- create/edit/delete player profile.
- select previously created profile, and continue playing. (a new game will be started if the player left in the middle of a previous game)
- clear their own game history.

## Dice API
This solution uses and HTTPClient to call rolz.API for returning random die rolls. The solution serializes the entire JSON from the API call into an object, but only uses the 'details' die rolls for displaying die amounts.
If the game can't connect to the API it just generates the die rolls locally with Math.Random.

## Known Bugs

- There is a weird visual bug I haven't been able to nail down, where the 'Let's Play Craps' Group Box will shift up into the middle of the data table above it. I haven't figured out what causes this bug, but if you see it happen let me know what you did!

- Ideally, the game 'numbers' in the games data table would increment individually for each player, but I didn't want to create a games table for every user account. I was planning on implementing RANK in a SQL query to handle this across players, but apparently WinForms DataTable Querys don't implement RANK, so I'll need to find another way to accomplish this. This also means that Game numbers don't start over after Player History has been deleted.

Have Fun!
