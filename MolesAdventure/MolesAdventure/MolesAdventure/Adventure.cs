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
        
        public Adventure()
        {
            Views = new List<IView>();
            Views.Add(new StringListView(new GameObject(), this,null,null,null));
            CurrentViewIndex = 0;
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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
            
            xnacontext = new XNAContext(graphics, spriteBatch,null,Color.Gold);
          
            
            // TODO: use this.Content to load your game content here
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
            throw new NotImplementedException();
        }


        public string GetPlayerName()
        {
            throw new NotImplementedException();
        }

        public int GetScore()
        {
            throw new NotImplementedException();
        }

        public void SetScore(int score)
        {
            throw new NotImplementedException();
        }

        public void AddScore(int score)
        {
            throw new NotImplementedException();
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
    }
}
