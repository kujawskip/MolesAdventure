using Generic_Game_Engine.Interfaces;
using Generic_Game_Engine.Objects.Views;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MolesAdventure.Factories
{
    public class ViewFactory
    {
        static Texture2D Background;
        static Texture2D Logo;
        static public void InitializeFactory(Texture2D Background,Texture2D Logo)
        {
            ViewFactory.Background = Background;
            ViewFactory.Logo = Logo;
        }
        static public MenuView createMainMenuView()
        {
            var BackgroundObject = GameObjectFactory.createSimpleDrawableObject(Background, new Generic_Game_Engine.Objects.Point());

            MenuView M = new MenuView(BackgroundObject, Adventure.GetInstance(), MenuFactory.createMainMenuItems());
            M.AddObject(GameObjectFactory.createSimpleDrawableObject(Logo, new Generic_Game_Engine.Objects.Point()));
            BackgroundObject.SetView(M);
            MenuFactory.finish(M,Logo.Bounds.Bottom);
            return M;

        }
    }
}