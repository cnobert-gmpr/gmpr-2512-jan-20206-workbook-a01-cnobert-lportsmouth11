using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lesson05KeyboardInput;



public class InputGame : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private string _message = "Hello";

    private SpriteFont _font;

    private KeyboardState _kbCurrentState, _kbPreviousState;


    public InputGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        _font = Content.Load<SpriteFont>("SystemArialFont");
    }

    protected override void Update(GameTime gameTime)
    {
        _kbCurrentState = Keyboard.GetState();
        _message = "";

        #region arrow keys
    
        if(IsNewKeyPress(Keys.Space))
        {
            _message += "\n";
            _message += "Space bar pressed \n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";
            _message += "--------------------------------------\n";


        }

        else if(_kbCurrentState.IsKeyDown(Keys.Space))
        {
            _message += "\n";
            _message += "Space bar is being held down.";
            
        }

        else if (_kbPreviousState.IsKeyDown(Keys.Space))
        {
            _message = "\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
            _message += "---------------------------------------------------------\n";
        }
        

        _kbPreviousState = _kbCurrentState;
        #endregion
        

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();

        if(_kbCurrentState.IsKeyDown(Keys.R))
        {
            GraphicsDevice.Clear(Color.Red);
        }


        _spriteBatch.DrawString(_font, _message, Vector2.Zero, Color.Wheat);


        _spriteBatch.End();

        base.Draw(gameTime);
    }

    private bool IsNewKeyPress(Keys key)
    {
        bool returnValue = _kbPreviousState.IsKeyUp(key) && _kbCurrentState.IsKeyDown(key);
        return returnValue;
    }
}
