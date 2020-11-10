# Zen.Assets

This is a helper project for a MonoGame project to store game assets.
It can be used to store and retreieve SpriteFonts, Textures, TextureAtlases, Sounds and Animations.

Nuget package download: https://www.nuget.org/packages/Zen.Assets/0.1.3

# Example
To use:
(for resources compiled to xnb's)

    // assumes Arial-12.xnb is in .\Content\Fonts folder
    AssetsManager.Instance.AddSpriteFont("Arial-12", "Fonts\\Arial-12");
    SpriteFont font = AssetsManager.Instance.GetSpriteFont("Arial-12");
    
    // assumes cursor.xnb is in .\Content\Textures folder
    AssetsManager.Instance.AddTexture("Cursor", "Textures\\cursor");
    Texture2D texture = AssetsManager.Instance.GetTexture("Cursor");

(for "native" resources, i.e. ttf, png, etc.)

    // this will load everything under Fonts (ttf), Textures (png) and TextureAtlases (atlasspec) folders,
    // bake them and store them in the AssetsManager
    ContentLoader.LoadContent(
        $@"{Directory.GetCurrentDirectory()}\Content\",
        "Fonts",
        "Textures",
        "TextureAtlases",
        graphicsDevice);
        
    // assumes Arial.ttf is in .\Content\Fonts folder
    SpriteFont font = AssetsManager.Instance.GetSpriteFont("Arial");

# Developer
Written by Greg Moller (greg.moller@gmail.com)
If you have any questions drop me a line at the above email.

# License
Licensed under the MIT License. See the LICENCE file for more information.
