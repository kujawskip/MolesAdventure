using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using XNA_Generic_Game_Library;
using Generic_Game_Engine.Interfaces;
using Generic_Game_Engine.Objects.Views;
using Generic_Game_Engine.Objects;
using MolesAdventure.Factories;

namespace MolesAdventure
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Adventure : Microsoft.Xna.Framework.Game,IGame
    {
        List<IView> Views;
        int CurrentViewIndex;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        XNAContext xnacontext;
        string PlayerName;
        int score;
        static private Adventure instance;
        static public Adventure GetInstance()
        {
            return instance;
        }
        public void StartGame()
        {
        }
        public void LoadGame()
        {
        }
        public void ChangeOptions()
        {
        }
        public void ViewHelp()
        {
        }
        public void ViewHighScores()
        {
        }
        public Adventure()
        {
            Views = new List<IView>();
           
            CurrentViewIndex = 0;
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 768;
            graphics.PreferredBackBufferWidth = 1024;
            Content.RootDirectory = "Content";
            instance = this;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            xnacontext = new XNAContext(graphics, spriteBatch,LoadFonts(),Color.Gold);
            var text = Content.Load<Texture2D>("titlescreen1");
            var logo = Content.Load<Texture2D>("logo");
            ViewFactory.InitializeFactory(text,logo);
            Views.Add(ViewFactory.createMainMenuView());
            
            // TODO: use this.Content to load your game content here
        }

        private SpriteFont[] LoadFonts()
        {
            List<SpriteFont> fonts = new List<SpriteFont>();
            for (int i = 10; i < 18; i += 2)
            {
                fonts.Add(Content.Load<SpriteFont>(i.ToString()));
            }
            return fonts.ToArray();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            Views[CurrentViewIndex].Update();
            
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            Views[CurrentViewIndex].Draw();
            
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        public KeyboardState GetKeyboardState()
        {
            return Keyboard.GetState();
        }


        public IContext GetGraphicalContext()
        {
            return xnacontext;
        }


        public string GetPlayerName()
        {
            throw new NotImplementedException();
        }

        public int GetScore()
        {
            return score;
        }

        public void SetScore(int score)
        {
            this.score = score;
        }

        public void AddScore(int score)
        {
            this.score += score;
        }


        public void SaveGame()
        {
            throw new NotImplementedException();
        }

        HighScores highscores;
        public void Quit()
        {
            throw new NotImplementedException();
        }


        public Generic_Game_Engine.Objects.Point GetViewSize()
        {
            return new Generic_Game_Engine.Objects.Point(1024, 768);
        }

        public Keys GetUpKey()
        {
            return keyboardstate ? Keys.Up : Keys.W;
        }
        bool keyboardstate;
        public Keys GetDownKey()
        {
            return keyboardstate ? Keys.Down : Keys.S;
        }


        public Keys GetAcceptKey()
        {
            return Keys.Enter;
        }
    }
}
