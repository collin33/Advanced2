using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;

namespace Advanced2
{
    public class Game1: Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D TestMikuTexture;

        Stopwatch _stopWatch;

        // GameObjects
        RotaterObject _rotaterObj;
        BounceObject _bounceObj;
        ScaleObject _scaleObj;

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

            // 2D Textures
            TestMikuTexture = Content.Load<Texture2D>("MikuLeek");

            // GameObjects
            _rotaterObj = new RotaterObject(1);
            _bounceObj = new BounceObject(96,3);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

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

            _rotaterObj.Time(elapsedTime);
            _rotaterObj.ObjectUpdate();

            _bounceObj.Time(elapsedTime);
            _bounceObj.ObjectUpdate();

            _stopWatch.Restart();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            // TODO: Add your drawing code here
            _rotaterObj._SpriteRenderer.Draw(_rotaterObj._Transform, _spriteBatch, TestMikuTexture);
            _bounceObj._SpriteRenderer.Draw(_bounceObj._Transform, _spriteBatch, TestMikuTexture);

            base.Draw(gameTime);
        }
    }
}
