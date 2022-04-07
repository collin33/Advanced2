using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Advanced2
{
    public class Game1: Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D TestMikuTexture;
        Texture2D _littleStarTexture;

        SpriteFont _defaultFont;

        Stopwatch _stopWatch;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            // Time
            _stopWatch = new Stopwatch();
            _stopWatch.Start();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            Viewport viewport = _graphics.GraphicsDevice.Viewport;
            _littleStarTexture = Content.Load<Texture2D>("LittleStar");
            _defaultFont = Content.Load<SpriteFont>("Arial");

            Transform testTransform = new Transform(new Vector2(viewport.Width * 0.5, viewport.Height * 0.5f));
            SpriteRenderer testRenderer = new SpriteRenderer(_littleStarTexture);
            Rotator testRotator = new Rotator(10, 2);
            Oscillator testOscillator = new Oscillator(10, 2);
            ColorShifterObject testColorShifter = new ColorShifter(2.0f);
            Scaler testScaler = new Scaler(2.0f);//optional

            List<MonoBehaviour> testComponents = new List<MonoBehaviour>
            {testRenderer, testRotator, testOscillator, testScaler};

            GameObject test = new GameObject("test", testTransform,
                new List<MonoBehaviour>() { testRenderer, testRotator, testOscillator, testColorShifter, testScaler });

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _stopWatch.Stop();
            TimeSpan ts = _stopWatch.Elapsed;

            int elapsedTime = ts.Milliseconds;
            //System.Diagnostics.Debug.Write("RunTime " + ts.Milliseconds);


            _stopWatch.Restart();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin(SpriteSortMode.FrontToBack);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
