using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;

namespace Advanced2
{
    public class OriginTestScene: Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D TestMikuTexture;

        Stopwatch _stopWatch;

        // GameObjects
        GameObject _gameObject1;
        GameObject _gameObject2;
        GameObject _gameObject3;
        GameObject _gameObject4;

        public OriginTestScene()
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
            _gameObject1 = new GameObject();
            _gameObject2 = new GameObject();
            _gameObject3 = new GameObject();
            _gameObject4 = new GameObject();

            _gameObject1._Transform.Position = new Vector2(96, 96);
            _gameObject2._Transform.Position = new Vector2(96, 96);
            _gameObject3._Transform.Position = new Vector2(96, 96);
            _gameObject4._Transform.Position = new Vector2(96, 96);

            _gameObject1._Transform.AnchorPoint = new Vector2(0, 0);
            _gameObject2._Transform.AnchorPoint = new Vector2(0, 1);
            _gameObject3._Transform.AnchorPoint = new Vector2(1, 0);
            _gameObject4._Transform.AnchorPoint = new Vector2(1, 1);

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

            _gameObject1.ObjectUpdate();
            _gameObject2.ObjectUpdate();
            _gameObject3.ObjectUpdate();
            _gameObject4.ObjectUpdate();

            _stopWatch.Restart();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _gameObject1._SpriteRenderer.Draw(_gameObject1._Transform, _spriteBatch, TestMikuTexture);
            _gameObject2._SpriteRenderer.Draw(_gameObject2._Transform, _spriteBatch, TestMikuTexture);
            _gameObject3._SpriteRenderer.Draw(_gameObject3._Transform, _spriteBatch, TestMikuTexture);
            _gameObject4._SpriteRenderer.Draw(_gameObject4._Transform, _spriteBatch, TestMikuTexture);

            base.Draw(gameTime);
        }
    }
}
