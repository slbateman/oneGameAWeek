

## Weeks 1–10: Absolute Fundamentals
**Skills learned**
- Scene setup
- Input handling (keyboard/mouse)
- Game loop thinking
- Timers
- Win/lose conditions
- Simple UI (score, restart)

### Click Counter
  - **Description**: A simple score-chasing game where a large button in the center of the screen increases your score every time you click it during a short round timer. The round ends when the timer hits zero, encouraging you to chase personal bests and compare scores between runs.
  - **Skills Focus**: Input handling, UI basics, timers.
  - **Art Assets**: Simple button sprite, background panel or solid-color backdrop, basic font or bitmap text for score and timer, optional subtle click effect graphic.
### Avoid the Cursor
  - **Description**: You control a small avatar that must dodge roaming hazards that move around the screen and react to your mouse position. The goal is to survive as long as possible without touching any enemy shapes as their speed and patterns gradually ramp up.
  - **Skills Focus**: Mouse input, basic collision, simple enemy movement.
  - **Art Assets**: Player icon, enemy/hazard shapes, simple background, hit effect or flash, minimal UI for timer/score.
### Timing Bar
  - **Description**: A marker slides back and forth along a bar while a highlighted target zone sits somewhere on it, and you must press a key when the marker overlaps the zone. Points are awarded based on how close you are to the center, turning it into a rhythm and anticipation challenge.
  - **Skills Focus**: Timing windows, easing, feedback/juice.
  - **Art Assets**: Bar background, moving marker, target zone highlight, background or frame, simple score text and feedback icons (e.g., miss/good/perfect).
### Falling Dodge
  - **Description**: Objects continuously fall from the top of the screen while you move left and right along the bottom lane to avoid getting hit. As you survive, the fall speed and spawn rate increase, turning simple dodges into intense weaving patterns.
  - **Skills Focus**: Keyboard movement, spawning, difficulty ramp.
  - **Art Assets**: Player sprite, falling obstacle sprite(s) or simple shapes, background, ground or lane indicator, hit effect, minimal HUD for time/score.
### One-Button Jump
  - **Description**: A side-on endless runner where your character automatically runs forward and you control everything with a single jump button. Carefully timed jumps are needed to clear gaps, spikes, and obstacles as the level layout becomes trickier over time.
  - **Skills Focus**: One-button design, jump physics tuning.
  - **Art Assets**: Player character run/jump frames (or simple silhouette), ground tiles or platforms, hazard sprites (gaps/spikes), background layer, basic HUD for distance/score.
### Endless Spinner
  - **Description**: You rotate a line or paddle around a central point to dodge or deflect blocks that fly in from all directions. Each close call or successful block increases your score until you eventually get hit and the run ends.
  - **Skills Focus**: Rotation, angle math, hitboxes.
  - **Art Assets**: Central spinner or paddle sprite, incoming block shapes, simple radial or abstract background, hit/deflect effect, score text.
### Simple Pong
  - **Description**: A minimalist Pong variant where you control a single paddle and bounce a ball against a wall or simple AI opponent. The ball rebounds at different angles based on where it hits the paddle, rewarding positioning and timing as you try to keep rallies going.
  - **Skills Focus**: Physics reflection, scoring, game loop.
  - **Art Assets**: Paddle sprite, ball sprite, wall/opponent side, playfield background or border, score UI, simple hit flash or trail.
### Color Match
  - **Description**: The screen periodically flashes a color while a small HUD shows which keys map to which colors, and you must hit the correct key before a short timer expires. Rounds speed up and color sequences get trickier, stressing both reaction and short-term memory.
  - **Skills Focus**: Input mapping, state changes, visual clarity.
  - **Art Assets**: Full-screen color backgrounds, small key-to-color legend icons, simple frame or layout, timer/score text, feedback graphics for correct/incorrect.
### Reaction Test
  - **Description**: The game waits a random amount of time with a neutral screen, then flashes a signal indicating you should click as fast as possible to stop the timer. Your reaction time is recorded and compared across multiple trials, encouraging you to improve your best score.
  - **Skills Focus**: Timing measurement, simple stats, UX polish.
  - **Art Assets**: Neutral screen state, “go” signal graphic, simple timer readout, basic results screen layout, optional small icons for best/average times.
### Maze Walk
  - **Description**: You navigate a compact maze from a clearly marked start to an exit using simple movement controls and clear wall collisions. The focus is on readable layout, subtle visual guidance, and making the act of exploring and reaching the goal satisfying.
  - **Skills Focus**: Grid layouts, collision with walls, camera framing.
  - **Art Assets**: Maze tiles (walls/floor), player icon, start and exit markers, minimal background or border, simple HUD or mini-map arrow if needed.

## Weeks 11–20: Basic Movement + State
- Skills learned
  - Player movement (2D vectors)
  - Collision detection
  - Game states (menu / play / end)
  - Basic enemy logic
  - Simple animations
  - Level transitions
### Platformer (No Enemies)
  - **Description**: A small side-scrolling platformer where you jump gaps, clear spikes, and ride moving platforms but face no active enemies. The challenge is to run and jump cleanly through the course, optionally grabbing collectibles or attempting speedrun routes.
  - **Skills Focus**: Platformer movement, gravity, coyote time.
  - **Art Assets**: Player character with run/jump frames, ground/platform tiles, spike or hazard sprites, optional collectible icon, simple background parallax or sky.
### Top-Down Walker
  - **Description**: A top-down character explores a compact environment filled with walls, obstacles, and points of interest but no combat. You focus on smooth navigation, collision, and discovering small environmental details or micro-objectives scattered around the map.
  - **Skills Focus**: Top-down movement, tile collisions, camera follow.
  - **Art Assets**: Top-down player sprite (2–4 directions or simplified), terrain tiles (floor/walls), a few prop sprites (trees, rocks, furniture), basic UI for hints/objectives.
### Chase Game
  - **Description**: You are chased by a single enemy that constantly attempts to reach your position within a confined arena. You must outmaneuver it using level geometry, speed differences, and maybe temporary boosts to survive as long as possible without being caught.
  - **Skills Focus**: Basic AI chasing, pathing shortcuts, tension.
  - **Art Assets**: Player sprite, chaser enemy sprite, arena tiles or boundaries, background, simple visual for power-ups or speed boosts, timer/score UI.
### Collectathon
  - **Description**: A compact level is filled with scattered collectibles that must all be gathered before a countdown reaches zero. Efficient movement, route planning, and optional risk–reward side paths determine whether you collect everything in time.
  - **Skills Focus**: Level item placement, timers, scoring.
  - **Art Assets**: Player sprite, collectible item icon, level tiles/background, timer/score UI, simple goal/exit marker.
### Breakout Clone
  - **Description**: You control a horizontal paddle at the bottom of the screen, bouncing a ball upward to break brick formations at the top. Clearing all bricks finishes the level, with optional simple power-ups like multi-ball or paddle size changes to spice up play.
  - **Skills Focus**: Physics bounce, level progression, power-ups (simple).
  - **Art Assets**: Paddle sprite, ball sprite, brick tiles (1–2 variants), playfield background or frame, simple icons for any power-ups, score and lives UI.
### Grid Puzzle
  - **Description**: On a grid-based map, you push crates or blocks around to line them up with designated goal tiles without trapping yourself. Each level is a small, handcrafted puzzle where a few wrong moves can create deadlocks that require a reset.
  - **Skills Focus**: Turn/step-based movement, undo logic, puzzle design.
  - **Art Assets**: Floor tile, wall tile, movable crate/block sprite, goal tile marker, player icon, minimal UI for move count/undo/reset.
### Memory Tiles
  - **Description**: A pattern of tiles lights up in sequence, and you must repeat it by selecting tiles in the same order once the sequence stops. Each round adds an extra step, gradually increasing difficulty and testing your visual and spatial memory.
  - **Skills Focus**: Pattern storage, replay, pacing of difficulty.
  - **Art Assets**: Tile sprites with idle and highlighted states, simple background or frame, UI for round/score, small feedback icons for correct/incorrect steps.
### Light Toggle Puzzle
  - **Description**: A grid of lights can be toggled on or off, typically affecting neighboring tiles in predefined patterns. You experiment and deduce the rules needed to transform the starting configuration into a target pattern, using as few moves as possible.
  - **Skills Focus**: Boolean state, neighbor rules, puzzle readability.
  - **Art Assets**: Light tile sprites for on/off states, optional highlight for selected tiles, simple background frame, minimal move counter or status text.
### Simple Shooter
  - **Description**: A straightforward 2D shooter where you move around a small arena and fire at a single type of enemy that periodically spawns. Enemies react when hit and eventually disappear, and your score climbs based on how many you defeat before taking too much damage.
  - **Skills Focus**: Projectile spawning, aiming, hit detection.
  - **Art Assets**: Player sprite, enemy sprite, bullet/projectile graphics, arena background, hit/explosion effect, health/score UI.
### Score Attack Arena
  - **Description**: A confined arena where enemies, targets, or hazards spawn in waves and you earn points for surviving and defeating them efficiently. The session ends after a fixed time or when you are overwhelmed, turning each run into a high-score chase.
  - **Skills Focus**: Wave spawning, score multipliers, session length.
  - **Art Assets**: Arena tiles/background, one or two enemy/target sprites, player sprite (or reticle), visual indicators for waves or multipliers, score/timer UI.

## Weeks 21–30: Multiple Systems
- Skills learned
  - Physics basics
  - Spawning systems
  - Difficulty scaling
  - Timing-based mechanics
  - Audio integration
  - Input + feedback feel
### Endless Runner
  - **Description**: A side-scrolling runner where your character automatically moves forward through an endless level, and you react to obstacles by jumping, sliding, or changing lanes. Chunks of level geometry repeat or randomize, creating a fast-paced, replayable challenge.
  - **Skills Focus**: Procedural obstacles, speed scaling, game feel.
  - **Art Assets**: Player character run/jump/slide poses, ground/platform tiles, obstacle sprites (e.g., spikes, barriers), parallax or simple background, basic HUD for distance/score.
### Asteroids Lite
  - **Description**: You pilot a small ship in open space, rotating to aim while managing thrust and inertia as you shoot asteroids that break into smaller pieces when hit. Survive as long as you can without colliding, clearing waves and chasing a high score.
  - **Skills Focus**: Momentum, screen wrapping, object pooling.
  - **Art Assets**: Player ship sprite, asteroid sprites (large/small variants), bullet graphics, starfield background, simple UI for lives and score.
### Stealth Avoidance
  - **Description**: You sneak through a level patrolled by guards whose vision cones are clearly shown, attempting to reach an exit or objective without being spotted. Getting caught sends you back to a checkpoint or restarts the level, emphasizing careful observation and timing.
  - **Skills Focus**: Field-of-view, enemy states, level layout for stealth.
  - **Art Assets**: Player sprite, guard sprites with simple patrol animations, vision cone visuals, floor/wall tiles, exit marker, small alert icons.
### Physics Stacker
  - **Description**: Objects fall from above one at a time, and you must catch or place them to build a stable stack without anything tumbling out of bounds. As the tower grows taller, physics become more precarious and each piece placement matters more.
  - **Skills Focus**: Physics engine use, constraints, fail conditions.
  - **Art Assets**: A few simple block shapes (2–3 variants), platform/ground sprite, background, subtle dust or impact effect, minimal UI for height/score.
### Path Timing Puzzle
  - **Description**: You navigate along a path or grid while hazards such as spinning blades, lasers, or moving blocks follow predictable cycles. To progress, you learn their patterns and step forward at just the right moments to slip safely between danger zones.
  - **Skills Focus**: Cyclic timelines, telegraphing, fair difficulty.
  - **Art Assets**: Player icon, path/floor tiles, hazard sprites (e.g., spinning blade, moving block, laser emitter), simple background, minimal level/attempt UI.
### Basic Platformer Combat
  - **Description**: A small platformer level populated by a single enemy archetype that patrols, charges, or shoots in simple patterns. You have one basic attack, such as a stomp or melee swing, and must learn when to attack safely while moving through the stage.
  - **Skills Focus**: Hitboxes/hurtboxes, knockback, simple enemy AI.
  - **Art Assets**: Player platformer sprite set, single enemy sprite with a couple of frames, basic tileset, hit effect sprite, health/score indicators.
### Turn-Based Grid Game
  - **Description**: On a tile-based grid, you and your enemies act in discrete turns, each choosing to move, attack, or use a special action. Careful positioning and anticipating enemy moves are key to clearing the map or reaching an objective alive.
  - **Skills Focus**: Turn systems, action queues, grid targeting.
  - **Art Assets**: Grid tiles, player and enemy unit icons, highlight for selected tile and movement/attack range, simple UI for turn/order and health.
### Puzzle Rooms
  - **Description**: A short sequence of five handcrafted rooms, each containing a distinct logic or interaction puzzle such as switches, keys, or pressure plates. Solving one room unlocks the door to the next, gradually introducing more complex combinations of mechanics.
  - **Skills Focus**: Puzzle progression, gating, hint design.
  - **Art Assets**: Room tiles (floor/walls), interactable sprites (switches, doors, keys, pressure plates), player icon, basic transition/door graphics, minimal UI for room index.
### Mini Golf
  - **Description**: You aim shots and control their power to knock a ball around obstacles toward a hole in as few strokes as possible. A small selection of holes introduces ramps, walls, and banking shots to encourage experimentation with angles and strength.
  - **Skills Focus**: Aiming UI, power meters, friction/bounce tuning.
  - **Art Assets**: Ball sprite, hole/flag sprite, course tiles (ground, wall, ramp), power meter UI, simple background, stroke counter display.
### Rhythm Taps
  - **Description**: Notes travel toward a hit zone in time with a fixed song, and you tap the correct buttons as they reach the target. Your accuracy and timing streak increase your score, with satisfying audio and visual feedback for well-timed hits.
  - **Skills Focus**: Beat syncing, input leniency, timing feedback.
  - **Art Assets**: Note icons, hit lane or track, hit zone marker, background (static or gently animated), feedback flashes, score/combo UI.

## Weeks 31–40: Design Challenges
- Skills learned
  - Finite State Machines (AI)
  - Data-driven design
  - Reusable components
  - Balancing
  - Simple UI flows
  - Multiplayer input handling
  - Boss design fundamentals
### Twin-Stick Shooter
  - **Description**: A top-down arena shooter where one input controls movement and another controls aiming direction, letting you fire independently while kiting enemies. You survive waves of foes, manage space, and constantly reposition to avoid being surrounded.
  - **Skills Focus**: Dual-input control, enemy patterns, arena design.
  - **Art Assets**: Top-down player sprite, enemy sprites (1–2 simple types), bullet/projectile graphics, arena tiles/background, hit/explosion effects, health/score UI.
### Wave Survival
  - **Description**: You defend yourself in a compact level as increasingly dense waves of enemies spawn over time. Between waves you may get small upgrades or brief breathing room, but the focus is on pacing, difficulty curves, and how long you can survive.
  - **Skills Focus**: Difficulty curves, spawn pacing, performance.
  - **Art Assets**: Player sprite, basic enemy sprites (reusable from other weeks if desired), arena background, simple upgrade icon(s), wave/timer/score HUD.
### Simple AI States
  - **Description**: Enemies patrol along predefined routes until they detect the player, switching into a chase state that makes them pursue aggressively. If they lose sight of you, they transition back to searching and eventually resume patrol, showcasing simple but readable AI behavior.
  - **Skills Focus**: Finite state machines, transitions, debugging AI.
  - **Art Assets**: Player sprite, guard/enemy sprites, clear indicators for alert/search/patrol states (icons or color tints), floor/wall tiles, minimal HUD.
### Card Battler Lite
  - **Description**: You bring a small deck of about ten cards, each with clear, deterministic effects, into short turn-based battles against a simple opponent. Success depends on sequencing your cards well and exploiting synergies rather than relying on randomness.
  - **Skills Focus**: Data-driven design, tooltips, balance.
  - **Art Assets**: Simple card frames, icons for card types/effects, player and enemy portraits or icons, board/background, UI for health and turn indicators.
### Tower Defense (1 Path)
  - **Description**: Enemies march along a single predetermined path while you place a limited set of tower types alongside it to stop them. Careful placement and upgrading of those few towers are required to prevent enemies from reaching the end of the path.
  - **Skills Focus**: Range/targeting, upgrade paths, enemy types.
  - **Art Assets**: Path tiles, tower sprites (3 simple types), enemy sprites, projectile or attack effect graphics, base/goal icon, health/wave/coins UI.
### Resource Balancer
  - **Description**: You manage two or three interconnected resources that can be converted between one another through actions, buildings, or trades. The challenge is to maintain a healthy balance or reach target amounts without running out of a critical resource.
  - **Skills Focus**: Economy loops, UI for trade-offs, tuning.
  - **Art Assets**: Icons for each resource, simple panel or board background, button graphics for actions/trades, basic charts or bars for resource amounts.
### Puzzle Platformer
  - **Description**: A side-scrolling platformer where progress is blocked not only by jumps but also by logic-based obstacles such as switches, pressure plates, or special abilities that affect the environment. Solving each section requires both precise movement and puzzle solving.
  - **Skills Focus**: Level scripting, teaching mechanics, puzzle pacing.
  - **Art Assets**: Player platformer sprite, ground/platform tiles, switch/door/pressure plate sprites, a few puzzle prop graphics, simple background, small HUD if needed.
### Dialogue Choice Game
  - **Description**: You experience a story primarily through conversations, picking dialogue options at key moments that branch scenes or adjust hidden narrative variables. Over time your choices shape relationships and lead to one of several possible endings.
  - **Skills Focus**: Dialogue trees, narrative flags, writing flow.
  - **Art Assets**: Character portraits or busts (minimal set), dialogue box UI, background illustrations or simple scene backdrops, choice button styles, basic title/end screen.
### Local Multiplayer Game
  - **Description**: Two or more players share a keyboard or controller to compete or cooperate in fast, simple matches. The design focuses on clear controls, readable feedback, and quick rounds that make it easy to play multiple games in a session.
  - **Skills Focus**: Multiple inputs, screen layout, fairness.
  - **Art Assets**: Distinct player sprites/colors, simple arena or playfield, clear indicators for player scores/round wins, minimal FX for interactions, menu/start screen.
### Boss Fight Only
  - **Description**: The entire game is centered on a single, multi-phase boss fight in a single arena with a clear set of patterns and telegraphed attacks. You learn the boss through repeated attempts, gradually recognizing patterns and mastering the moves needed to win.
  - **Skills Focus**: Boss phases, telegraphs, learning loops.
  - **Art Assets**: Player sprite, boss sprite with a few poses or phase variations, arena background, attack telegraph graphics, hit/hurt effects, health bars for both sides.

## Weeks 41–52: Stretch but Realistic
- Procedural generation
  - Randomization with constraints
  - Inventory systems
  - Save-like persistence
  - Narrative branching
  - Time manipulation logic
  - Asymmetric mechanics
  - Polish & iteration
### Mini Roguelike
  - **Description**: A bite-sized roguelike where each run is a short sequence of about five rooms presented in random order, featuring simple turn-based combat and light loot. Death sends you back to the start, but quick runs encourage experimentation with different routes and strategies.
  - **Skills Focus**: Procedural generation, lightweight loot, run resets.
  - **Art Assets**: Tile set for rooms (floors/walls), player and enemy icons, item/loot icons, simple room transition visuals, minimal HUD for health and inventory.
### Procedural Maze
  - **Description**: Each playthrough generates a new maze layout that you must navigate to find an exit or specific goal. You reveal the map as you explore, using landmarks and simple mapping cues to avoid getting lost in the randomized corridors.
  - **Skills Focus**: Maze algorithms, seeding, replayability.
  - **Art Assets**: Maze wall/floor tiles, player icon, exit marker, optional mini-map or fog-of-war overlay, basic background or border.
### Auto-Battler Prototype
  - **Description**: Before each round of combat, you place a few units onto a board or formation grid, then sit back as they automatically fight an enemy team. Short runs highlight how positioning and basic unit synergies influence the outcome without overwhelming complexity.
  - **Skills Focus**: Unit behaviors, auto-resolution, synergies (simple).
  - **Art Assets**: Board/grid tiles, unit icons or tiny sprites (player and enemy), simple attack/effect graphics, UI for health/bars and round result screen.
### Inventory Puzzle
  - **Description**: You have a small, limited inventory and a set of items that interact with the world and with each other in specific ways. To solve each scenario, you must choose which items to carry, when to combine them, and how to use them in the correct order.
  - **Skills Focus**: Inventory UI, item rules, planning pressure.
  - **Art Assets**: Inventory slots UI, item icons (handful only), simple scene or puzzle background, cursor/highlight graphics, short text panel for descriptions.
### Metroidvania Slice
  - **Description**: A compact Metroidvania-style area where you begin with limited mobility, eventually unlocking a single new movement or combat ability that opens up a previously inaccessible path. You explore, find the ability, backtrack to the gate, and reach a clear final goal.
  - **Skills Focus**: Gating design, map readability, ability feel.
  - **Art Assets**: Player platformer sprite with one upgrade-related visual, environment tiles (a small tileset), door/gate icon, upgrade pickup sprite, mini-map or simple area map if time allows.
### Farming Loop Lite
  - **Description**: On a small farm plot, you plant seeds, wait for them to grow over in-game time, and harvest crops that you can sell or reinvest into better seeds or tools. The focus is on a cozy, repeatable loop of planning, waiting, and reaping rewards.
  - **Skills Focus**: Day cycles, growth timers, satisfying loops.
  - **Art Assets**: Farm ground tiles, crop sprites with a few growth stages for 1–3 plants, player farmer sprite, simple UI for time/day and inventory/money.
### Weather System Game
  - **Description**: You play through simple levels or encounters where a dynamic weather system periodically shifts conditions—rain might slow movement or reduce visibility, while wind can push projectiles or platforms. Adapting your strategy to each weather change is the core challenge.
  - **Skills Focus**: Global modifiers, visual feedback, systemic design.
  - **Art Assets**: Base environment tiles, weather overlays (rain, wind, maybe snow or fog), player sprite, simple icons or indicators showing current weather effect, basic HUD.
### Moral Choice Game
  - **Description**: A narrative-focused game where you make clear moral decisions at key story beats, with each choice tracked over time. Moment-to-moment gameplay stays simple so that the weight of your decisions and the endings they unlock remain the main focus.
  - **Skills Focus**: Choice tracking, branching endings, payoff.
  - **Art Assets**: Character portraits or silhouettes, dialogue and choice UI, a few background scenes, simple iconography for major choices or factions, end screen variants.
### Physics Combat Arena
  - **Description**: A compact arena where your attacks and abilities apply strong physical forces to enemies, sending them flying into hazards or off the stage. The impact, knockback, and visual effects are tuned to make every successful hit feel punchy and satisfying.
  - **Skills Focus**: Physics forces, camera shake, juice.
  - **Art Assets**: Player and enemy sprites, arena tiles/background with clear edges and hazards, impact and knockback FX, health/stock UI, minimal menu.
### Time Rewind Mechanic
  - **Description**: You tackle small challenges or combat encounters with the ability to rewind the last few seconds of gameplay at will. Levels are designed so that rewinding enables creative solutions or second chances rather than simply brute-forcing your way through.
  - **Skills Focus**: State recording, rewind UI, constraints.
  - **Art Assets**: Player sprite, simple level tiles/objects, rewind visual effect (trail, overlay, or vignette), icon/UI element for rewind meter, basic HUD.
### Asymmetric Gameplay
  - **Description**: You control a character that plays by one set of rules and abilities while the environment or opposing side operates under noticeably different ones. This asymmetry forces you to think differently about objectives, strategies, and how to exploit or overcome the rule differences.
  - **Skills Focus**: Rule systems, asymmetry balance, onboarding.
  - **Art Assets**: Player sprite, opposing-side representation (e.g., hazard icons, AI avatar, or board elements), environment tiles, clear UI showing each side’s key stats or rules.
### Polish Week
  - **Description**: You revisit your favorite prototype from earlier in the year and dedicate the entire week to improving visuals, audio, controls, menus, and stability. Instead of adding new mechanics, you focus on turning a rough but fun idea into something you would proudly show other people.
  - **Skills Focus**: UX polish, juice, menus, save/load, bugfixing.
  - **Art Assets**: Refined versions of existing assets from the chosen prototype, plus any missing UI elements (menus, buttons, icons) needed to feel “finished”; no brand-new asset categories.
