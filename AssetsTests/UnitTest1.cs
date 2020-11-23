using Microsoft.Xna.Framework.Graphics;
using NUnit.Framework;
using Zen.Assets;

namespace Zen.AssetsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Texture_can_be_added()
        {
            Texture2D texture1 = null;
            AssetsManager.Instance.AddTexture("Foo", texture1);

            Assert.AreEqual(texture1, AssetsManager.Instance.GetTexture("Foo"));

            Texture2D texture2 = null;
            AssetsManager.Instance.AddTexture("Foo", texture2);

            Assert.AreEqual(texture2, AssetsManager.Instance.GetTexture("Foo"));
        }
    }
}