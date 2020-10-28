# Zen.Assets

This is a helper project for a MonoGame project to store game assets.
It can be used to store and retreieve SpriteFonts, Textures, TextureAtlases, Sounds and Animations.

# Example
To use:

    // assumes Arial-12.xnb is in Content\Fonts folder
    AssetsManager.Instance.AddSpriteFont("Arial-12", "Fonts\\Arial-12");
    SpriteFont font = AssetsManager.Instance.GetSpriteFont("Arial-12");
    
    // assumes cursor.xnb is in Content\Textures folder
    AssetsManager.Instance.AddTexture("Cursor", "Textures\\cursor");
    Texture2D texture = AssetsManager.Instance.GetTexture("Cursor");
    
# Developer
Written by Greg Moller (greg.moller@gmail.com)

# License
Licensed under the MIT License. See the LICENCE file for more information.
