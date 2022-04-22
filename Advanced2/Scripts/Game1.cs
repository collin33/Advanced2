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
        Texture2D _sonicSpriteSheet;

        SpriteFont _defaultFont;

        Stopwatch _stopWatch;


        GameObject test0;
        GameObject test1;
        GameObject test2;
        GameObject test3;
        GameObject test4;
        GameObject test5;
        GameObject test6;
        GameObject test7;

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
            _sonicSpriteSheet = Content.Load<Texture2D>("SonicRunSpritesheet");
            _testMikuTexture = Content.Load<Texture2D>("MikuLeek");
            _defaultFont = Content.Load<SpriteFont>("Arial");

            CreateObjects(viewport);
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
            test7.Update(elapsedTime);
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
            test7.Draw();
            _spriteBatch.End();

            base.Draw(gameTime);
        }
        private void CreateObjects(Viewport viewport)
        {

            Transform transform0 = new Transform(new Vector2(viewport.Width * 0.32f, viewport.Height * 0.19f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));
            Transform transform1 = new Transform(new Vector2(viewport.Width * 0.68f, viewport.Height * 0.19f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));
            Transform transform2 = new Transform(new Vector2(viewport.Width * 0.15f, viewport.Height * 0.50f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));
            Transform transform3 = new Transform(new Vector2(viewport.Width * 0.85f, viewport.Height * 0.50f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));
            Transform transform4 = new Transform(new Vector2(viewport.Width * 0.32f, viewport.Height * 0.81f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));
            Transform transform5 = new Transform(new Vector2(viewport.Width * 0.68f, viewport.Height * 0.81f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));
            Transform transform6 = new Transform(new Vector2(viewport.Width * 0.50f, viewport.Height * 0.50f), new Vector2(0.5f, 0.5f), 0, new Vector2(1, 1));
            Transform transform7 = new Transform(new Vector2((viewport.Width * 0.50f)-66, (viewport.Height * 0.68f)-33), new Vector2(0f, 0f), 0, new Vector2(2, 2));


            SpriteRenderer testRenderer0 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            SpriteRenderer testRenderer1 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            SpriteRenderer testRenderer2 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            SpriteRenderer testRenderer3 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            SpriteRenderer testRenderer4 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            SpriteRenderer testRenderer5 = new SpriteRenderer(_testMikuTexture, _spriteBatch);
            SpriteRenderer testRenderer6 = new SpriteRenderer(_testMikuTexture, _spriteBatch);

            AnimatedSpriteRenderer testRenderer7 = new AnimatedSpriteRenderer(_sonicSpriteSheet, _spriteBatch, new Vector2 (66,66), new Vector2(6,1));

            Rotator testRotator0 = new Rotator(5);
            Rotator testRotator1 = new Rotator(5);
            Rotator testRotator2 = new Rotator(5);
            Rotator testRotator3 = new Rotator(5);
            Rotator testRotator4 = new Rotator(5);

            Bouncer testBouncer0 = new Bouncer(30, 0.5f);
            Bouncer testBouncer1 = new Bouncer(30, 0.5f);
            Bouncer testBouncer2 = new Bouncer(30, 0.5f);
            Bouncer testBouncer3 = new Bouncer(30, 0.5f);
            Bouncer testBouncer4 = new Bouncer(30, 0.5f);
            Bouncer testBouncer5 = new Bouncer(30, 0.5f);

            ColorShifter testcolorShifter0 = new ColorShifter(3f);
            ColorShifter testcolorShifter1 = new ColorShifter(3f);
            ColorShifter testcolorShifter2 = new ColorShifter(3f);
            ColorShifter testcolorShifter3 = new ColorShifter(3f);

            Scaler testScaler0 = new Scaler(0.4f, 0.2f);
            Scaler testScaler1 = new Scaler(0.4f, 0.2f);
            Scaler testScaler2 = new Scaler(0.4f, 0.2f);

            test0 = new GameObject("test", transform0, new List<Component> { testRenderer0, testRotator1, testBouncer5 });
            test1 = new GameObject("test", transform1, new List<Component> { testRenderer1, testRotator2, testcolorShifter1 });
            test2 = new GameObject("test", transform2, new List<Component> { testRenderer2, testScaler2, testBouncer1, testRotator3 });
            test3 = new GameObject("test", transform3, new List<Component> { testRenderer3, testBouncer2, testcolorShifter3, testRotator4 });
            test4 = new GameObject("test", transform4, new List<Component> { testRenderer4, testScaler1, testBouncer3 });
            test5 = new GameObject("test", transform5, new List<Component> { testRenderer5, testcolorShifter2, testBouncer4 });
            test6 = new GameObject("test", transform6, new List<Component> { testRenderer6, testRotator0, testBouncer0, testcolorShifter0, testScaler0 });
            test7 = new GameObject("test", transform7, new List<Component> { testRenderer7 });

            // TODO: use this.Content to load your game content here

            test0.Awake();
            test1.Awake();
            test2.Awake();
            test3.Awake();
            test4.Awake();
            test5.Awake();
            test6.Awake();
            test7.Awake();
        }
    }
}
