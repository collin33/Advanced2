using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;

namespace Advanced2
{
    public class ScaleTestScene: Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D TestMikuTexture;

        Stopwatch _stopWatch;

        // GameObjects
        GameObject _gameObject1;
        GameObject _gameObject2A;
        GameObject _gameObject2B;
        GameObject _gameObject3A;
        GameObject _gameObject3B;
        GameObject _gameObject3C;

        public ScaleTestScene()
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
            _gameObject2A = new GameObject();
            _gameObject2B = new GameObject();
            _gameObject3A = new GameObject();
            _gameObject3B = new GameObject();
            _gameObject3C = new GameObject();

            // GameObject transform positions
            _gameObject1._Transform.Position = new Vector2(0, 0);
            _gameObject2A._Transform.Position = new Vector2(96*3, 96*0);
            _gameObject2B._Transform.Position = new Vector2(96*3, (int)(96*1.5));
            _gameObject3A._Transform.Position = new Vector2((int)(96*4.5), 96*0);
            _gameObject3B._Transform.Position = new Vector2((int)(96*4.5), 96*1);
            _gameObject3C._Transform.Position = new Vector2((int)(96*4.5), 96*2);

            // GameObject Anchorpoints
            _gameObject1._Transform.AnchorPoint = new Vector2(0, 0);
            _gameObject2A._Transform.AnchorPoint = new Vector2(0, 0);
            _gameObject2B._Transform.AnchorPoint = new Vector2(0, 0);
            _gameObject3A._Transform.AnchorPoint = new Vector2(0, 0);
            _gameObject3B._Transform.AnchorPoint = new Vector2(0, 0);
            _gameObject3C._Transform.AnchorPoint = new Vector2(0, 0);

            _gameObject1._Transform.Scale = new Vector2(3, 3);
            _gameObject2A._Transform.Scale = new Vector2((float)(1.5), (float)(1.5));
            _gameObject2B._Transform.Scale = new Vector2((float)(1.5), (float)(1.5));
            _gameObject3A._Transform.Scale = new Vector2(1, 1);
            _gameObject3B._Transform.Scale = new Vector2(1, 1);
            _gameObject3C._Transform.Scale = new Vector2(1, 1);

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
            _gameObject1.ObjectUpdate();
            _gameObject2A.ObjectUpdate();
            _gameObject2B.ObjectUpdate();
            _gameObject3A.ObjectUpdate();
            _gameObject3B.ObjectUpdate();
            _gameObject3C.ObjectUpdate();

            _stopWatch.Restart();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _gameObject1._SpriteRenderer.Draw(_gameObject1._Transform, _spriteBatch, TestMikuTexture);
            _gameObject2A._SpriteRenderer.Draw(_gameObject2A._Transform, _spriteBatch, TestMikuTexture);
            _gameObject2B._SpriteRenderer.Draw(_gameObject2B._Transform, _spriteBatch, TestMikuTexture);
            _gameObject3A._SpriteRenderer.Draw(_gameObject3A._Transform, _spriteBatch, TestMikuTexture);
            _gameObject3B._SpriteRenderer.Draw(_gameObject3B._Transform, _spriteBatch, TestMikuTexture);
            _gameObject3C._SpriteRenderer.Draw(_gameObject3C._Transform, _spriteBatch, TestMikuTexture);

            base.Draw(gameTime);
        }
    }
}
