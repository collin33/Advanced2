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
        Texture2D _testMikuTexture;
        Texture2D _littleStarTexture;

        SpriteFont _defaultFont;

        Stopwatch _stopWatch;


        GameObject test0;
        GameObject test1;
        GameObject test2;
        GameObject test3;
        GameObject test4;
        GameObject test5;
        GameObject test6;

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
            base.LoadContent();
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            Viewport viewport = _graphics.GraphicsDevice.Viewport;
            _littleStarTexture = Content.Load<Texture2D>("LittleStar");
            _testMikuTexture = Content.Load<Texture2D>("MikuLeek");
            _defaultFont = Content.Load<SpriteFont>("Arial");

            Transform transform0 = new Transform(new Vector2(viewport.Width * 0.32f, viewport.Height * 0.19f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));
            Transform transform1 = new Transform(new Vector2(viewport.Width * 0.68f, viewport.Height * 0.19f), new Vector2(0.5f, 0.5f), 0, new Vector2(1 ,1));
            Transform transform2 = new Transform(new Vector2(viewport.Width * 0.15f, viewport.Height * 0.50f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));
            Transform transform3 = new Transform(new Vector2(viewport.Width * 0.85f, viewport.Height * 0.50f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));
            Transform transform4 = new Transform(new Vector2(viewport.Width * 0.32f, viewport.Height * 0.81f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));
            Transform transform5 = new Transform(new Vector2(viewport.Width * 0.68f, viewport.Height * 0.81f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));
            Transform transform6 = new Transform(new Vector2(viewport.Width * 0.50f, viewport.Height * 0.50f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));

            SpriteRenderer testRenderer0 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            SpriteRenderer testRenderer1 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            SpriteRenderer testRenderer2 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            SpriteRenderer testRenderer3 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            SpriteRenderer testRenderer4 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            SpriteRenderer testRenderer5 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            SpriteRenderer testRenderer6 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            Rotator testRotator1 = new Rotator(10);
            Rotator testRotator2 = new Rotator(10);
            Bouncer testBouncer1 = new Bouncer(30, 0.5f);
            Bouncer testBouncer2 = new Bouncer(30, 0.5f);
            ColorShifter testcolorShifter1 = new ColorShifter(3f);
            ColorShifter testcolorShifter2 = new ColorShifter(3f);

            //Oscillator testOscillator = new Oscillator(10, 2);
            //ColorShifterObject testColorShifter = new ColorShifter(2.0f);
            //Scaler testScaler = new Scaler(2.0f);//optional

            //GameObject test = new GameObject("test", testTransform, new List<MonoBehaviour>() { testRenderer, testRotator, testOscillator, testColorShifter, testScaler});
            test0 = new GameObject("test", transform0, new List<MonoBehaviour> { testRenderer0, testRotator2, testBouncer1});
            test1 = new GameObject("test", transform1, new List<MonoBehaviour> { testRenderer1, testBouncer2, testcolorShifter1});
            test2 = new GameObject("test", transform2, new List<MonoBehaviour> { testRenderer2, testRotator1 });
            test3 = new GameObject("test", transform3, new List<MonoBehaviour> { testRenderer3, testcolorShifter2 });
            test4 = new GameObject("test", transform4, new List<MonoBehaviour> { testRenderer4 });
            test5 = new GameObject("test", transform5, new List<MonoBehaviour> { testRenderer5 });
            test6 = new GameObject("test", transform6, new List<MonoBehaviour> { testRenderer6 });

            // TODO: use this.Content to load your game content here

            test0.Awake();
            test1.Awake();
            test2.Awake();
            test3.Awake();
            test4.Awake();
            test5.Awake();
            test6.Awake();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _stopWatch.Stop();
            TimeSpan ts = _stopWatch.Elapsed;

            int elapsedTime = ts.Milliseconds;
            //System.Diagnostics.Debug.Write("RunTime " + ts.Milliseconds);

            test0.Update(elapsedTime);
            test1.Update(elapsedTime);
            test2.Update(elapsedTime);
            test3.Update(elapsedTime);
            test4.Update(elapsedTime);
            test5.Update(elapsedTime);
            test6.Update(elapsedTime);
            _stopWatch.Restart();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin(SpriteSortMode.FrontToBack);
            test0.Draw();
            test1.Draw();
            test2.Draw();
            test3.Draw();
            test4.Draw();
            test5.Draw();
            test6.Draw();
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
