# HW4
## Devlog
In minigame 4 the Player/bird logic acts as the Control, and the UI acts as the View. The Bird class is the control because within it, it reads the input of the player movement where Update() check Input.GetKeyDown.(KeyCode.Space). It also uses physics to apply movement using _rigidbody.velocity = new Vector2.... as well as _jumpVelocity. Lastly, it also detects all the bird's gameplay interactions such as when hits a pipe and "dies" (OnCollisionEnter2D(Collision2D collision), and when it hits the invisible wall were it detects earning a point (OnTriggerEnter2D(Collider2D other).
The View I think would be in the Locator class that's responsible for the UI updates. It has a UI reference (TMP_Text, _scoreText), and it updates what the player sees on screen.
The player code is decoupled because I made it so that the Birds does not directly call any UI code. Rather, it raises an event when the score changes, and then the UI listens to that callout. I used a singleton pattern for the main global manager script. For example, Locator.Instance is used to access shared functionality without having to manually drag references.
## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
