using Devcade;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvader
{
    public class Game1 : Game
    {
        public static Game1 game;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public InputManager inputMan;
        private Rectangle windowSize;

        private Ship spaceShip;
        private Texture2D shipTexture;
        private Vector2 shipPos;

        /// <summary>
        /// Game constructor
        /// </summary>
        public Game1()
        {
            game = this;
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        /// <summary>
        /// Does any setup prior to the first frame that doesn't need loaded content.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            Input.Initialize(); // Sets up the input library

            // Set window size if running debug (in release it will be fullscreen)
            #region Setting Window Size
#if DEBUG
            _graphics.PreferredBackBufferWidth = 420;
            _graphics.PreferredBackBufferHeight = 980;
            _graphics.ApplyChanges();
#else
			_graphics.PreferredBackBufferWidth = GraphicsDevice.DisplayMode.Width;
			_graphics.PreferredBackBufferHeight = GraphicsDevice.DisplayMode.Height;
			_graphics.ApplyChanges();
#endif
            #endregion

            windowSize = GraphicsDevice.Viewport.Bounds;
            inputMan = new InputManager();
            shipPos = new Vector2((windowSize.Width / 2) - 64, windowSize.Height - 200);
            base.Initialize();
        }


        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            // ex.
            // texture = Content.Load<Texture2D>("fileNameWithoutExtention");
            shipTexture = Content.Load<Texture2D>("spaceship");
            spaceShip = new Ship(shipPos, shipTexture);
        }

        /// <summary>
        /// Your main update loop. This runs once every frame, over and over.
        /// </summary>
        /// <param name="gameTime">This is the gameTime object you can use to get the time since last frame</param>
        protected override void Update(GameTime gameTime)
        {
            Input.Update(); // Updates the state of the input library

            // Exit when both menu buttons are pressed (or escape for keyboard debuging)
            // You can change this but it is suggested to keep the keybind of both menu
            // buttons at once for gracefull exit.
            if (Keyboard.GetState().IsKeyDown(Keys.Escape) ||
                (Input.GetButton(1, Input.ArcadeButtons.Menu) &&
                Input.GetButton(2, Input.ArcadeButtons.Menu)))
            {
                Exit();
            }

            inputMan.UpdateInputs();

            spaceShip.Update(gameTime, _spriteBatch);

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// Your main draw loop. This runs once every frame, over and over.
        /// </summary>
        /// <param name="gameTime">This is the gameTime object you can use to get the time since last frame.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
            // TODO: Add your drawing code here
            spaceShip.Draw(gameTime, _spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}