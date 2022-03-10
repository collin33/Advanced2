using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Advanced2
{
    public class Game1: Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D TestMikuTexture;

        //Test object
        GameObject _testObj;
        Transform _testObjT;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            // 2D Textures
            TestMikuTexture = Content.Load<Texture2D>("MikuLeek");

            _testObjT = new Transform(new Vector2(5,5), new Vector2((float)1, (float)1), 10, new Vector2(4, 4));
            _testObj = new SpriteRenderer(TestMikuTexture);

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

            // TODO: Add your update logic here
            _spriteBatch.Begin();
            //_testObj.Draw(_testObjT, _spriteBatch, TestMikuTexture);

            _spriteBatch.End();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _testObj.Draw(_testObjT, _spriteBatch, TestMikuTexture);
            // TODO: Add your drawing code here
            //_testObject._SpriteRenderer(TestMikuTexture, _spriteBatch);
            base.Draw(gameTime);
        }
    }
}
