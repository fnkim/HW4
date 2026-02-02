# HW4
## Devlog
In this project, the model-view-control pattern decouples the Player script from the other systems in the game using a Singleton and events. The Locator, which is a Singleton, allows all the other scripts to connect the Player script and allows Player to send out signals to the other scripts when an event happens, meaning I don't need to edit the Player script directly to affect things like UI and pipe spawning.


For example, the Player script has the Points Delegate which passes an int parameter. The delegate has the event AddPoint that gets invoked by the OnTriggerEnter2D method, which gets triggered when the bird passes through the trigger collider past the pipes. It adds 1 to the variable _points and invokes the event through "AddPoint?.Invoke(_points);". The script UIStuff connects the AddPoint event to the method HandlePoints, and HandlePoints takes the _points which is passed through the parameter and shows that number in the UI with "_pointsUI.text = "Points: " + points.ToString();". This means the "control," which is the points logic of the game, is handled by the Player script, which is separated from the "view," which is the aesthetics and results of the game, which is handled by the UI script.


For another example, I made another Delegate which does not pass a parameter, simply called "Delegate", which has an event called "Died". When the OnCollisionEnter2D() method detects the player colliding with a pipe, it invokes the event "Died". The GameController script, which spawns the pipes, listens for "Died" from the Player script. It connects that event to the method Death(), which stops spawning the pipes, deletes all instantiated pipes, and stops the player from moving. This is an example of the "Controller" logic of whether you are playing or have triggered Game Over, affects the "View", which visually shows or hides the pipes.


## Open-Source Assets
If you added any other assets, list them here!
- [Wing Flap 1](https://pixabay.com/sound-effects/film-special-effects-wing-flap-1-6434/) - flap sound effect
- [2D Pixel Art Pidgeon Sprites](https://elthen.itch.io/2d-pixel-art-pidgeon-sprites) - pigeon sprite
- [8-Bit GAME OVER Sound Effect](https://pixabay.com/sound-effects/film-special-effects-8-bit-game-over-sound-effect-331435/) - game over sound effect
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
