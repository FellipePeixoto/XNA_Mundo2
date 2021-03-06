﻿#region using
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Mundo3.SetRec;
using Mundo3.Objects;
#endregion

namespace Mundo3.Manager
{
    static class SceneManager
    {
        #region private
        static List<Scene> scenes;
        static GraphicsDevice staticDevice;
        static Scene actualScene;
        static Screen screen;
        static Camera camera;
        static Chopper chooper;
        #endregion

        public static void Initialize(GraphicsDevice device, int screenWidth, int screenHeight)
        {
            staticDevice = device;

            screen = Screen.GetInstance();
            screen.SetWidth(screenWidth);
            screen.SetHeight(screenHeight);

            camera = Camera.GetInstance();
            camera.SetCameraPosition(new Vector3(22, 5, 17));
            camera.SetCameraTarget(Vector3.Zero);
        }

        public static void LoadContent(ContentManager content)
        {
            //TODO: Create Objects to include on set
            chooper = new Chopper();
            #region set do helicoptero
            List<Quad> heliBody = new List<Quad> 
            { 
                #region heli body
		new Quad(new Vector3(-0.50f,-0.00f,1.50f),
new Vector3(-0.50f,0.20f,1.50f),
new Vector3(-0.70f,0.20f,1.50f),
new Vector3(-0.70f,-0.00f,1.50f),
Color.Black),

new Quad(new Vector3(-1.00f,0.60f,-0.50f),
new Vector3(-1.00f,2.60f,-0.50f),
new Vector3(1.00f,2.60f,-0.50f),
new Vector3(1.00f,0.60f,-0.50f),
Color.Black),

new Quad(new Vector3(-0.70f,-0.00f,1.50f),
new Vector3(-0.70f,0.20f,1.50f),
new Vector3(-0.70f,0.20f,-0.50f),
new Vector3(-0.70f,0.00f,-0.50f),
Color.Black),

new Quad(new Vector3(-1.00f,2.60f,0.50f),
new Vector3(1.00f,2.60f,0.50f),
new Vector3(1.00f,2.60f,-0.50f),
new Vector3(-1.00f,2.60f,-0.50f),
Color.Black),

new Quad(new Vector3(-0.50f,0.20f,-0.30f),
new Vector3(-0.70f,0.20f,-0.30f),
new Vector3(-0.70f,0.60f,-0.30f),
new Vector3(-0.50f,0.60f,-0.30f),
Color.Black),

new Quad(new Vector3(-0.70f,0.00f,-0.50f),
new Vector3(-0.70f,0.20f,-0.50f),
new Vector3(-0.50f,0.20f,-0.50f),
new Vector3(-0.50f,0.00f,-0.50f),
Color.Black),

new Quad(new Vector3(-0.50f,0.00f,-0.50f),
new Vector3(-0.50f,-0.00f,1.50f),
new Vector3(-0.70f,-0.00f,1.50f),
new Vector3(-0.70f,0.00f,-0.50f),
Color.Black),

new Quad(new Vector3(-0.50f,-0.00f,1.50f),
new Vector3(-0.50f,0.00f,-0.50f),
new Vector3(-0.50f,0.20f,-0.50f),
new Vector3(-0.50f,0.20f,1.50f),
Color.Black),

new Quad(new Vector3(-0.50f,0.20f,1.50f),
new Vector3(-0.50f,0.20f,-0.50f),
new Vector3(-0.70f,0.20f,-0.50f),
new Vector3(-0.70f,0.20f,1.50f),
Color.Black),

new Quad(new Vector3(-0.70f,0.20f,1.00f),
new Vector3(-0.70f,0.20f,1.30f),
new Vector3(-0.70f,0.60f,1.30f),
new Vector3(-0.70f,0.60f,1.00f),
Color.Black),

new Quad(new Vector3(-0.09f,0.62f,-3.50f),
new Vector3(-0.09f,1.58f,-3.50f),
new Vector3(0.09f,1.58f,-3.50f),
new Vector3(0.09f,0.62f,-3.50f),
Color.Black),

new Quad(new Vector3(0.30f,0.80f,-0.50f),
new Vector3(-0.30f,0.80f,-0.50f),
new Vector3(-0.09f,0.80f,-2.50f),
new Vector3(0.09f,0.80f,-2.50f),
Color.Black),

new Quad(new Vector3(-0.30f,0.80f,-0.50f),
new Vector3(-0.30f,1.40f,-0.50f),
new Vector3(-0.09f,1.40f,-2.50f),
new Vector3(-0.09f,0.80f,-2.50f),
Color.Black),

new Quad(new Vector3(-0.50f,0.20f,1.00f),
new Vector3(-0.70f,0.20f,1.00f),
new Vector3(-0.70f,0.60f,1.00f),
new Vector3(-0.50f,0.60f,1.00f),
Color.Black),

new Quad(new Vector3(-0.50f,0.20f,-0.00f),
new Vector3(-0.50f,0.20f,-0.30f),
new Vector3(-0.50f,0.60f,-0.30f),
new Vector3(-0.50f,0.60f,-0.00f),
Color.Black),

new Quad(new Vector3(-0.70f,0.20f,-0.30f),
new Vector3(-0.70f,0.20f,-0.00f),
new Vector3(-0.70f,0.60f,-0.00f),
new Vector3(-0.70f,0.60f,-0.30f),
Color.Black),

new Quad(new Vector3(-0.50f,0.20f,1.30f),
new Vector3(-0.50f,0.20f,1.00f),
new Vector3(-0.50f,0.60f,1.00f),
new Vector3(-0.50f,0.60f,1.30f),
Color.Black),

new Quad(new Vector3(-0.70f,0.20f,-0.00f),
new Vector3(-0.50f,0.20f,-0.00f),
new Vector3(-0.50f,0.60f,-0.00f),
new Vector3(-0.70f,0.60f,-0.00f),
Color.Black),

new Quad(new Vector3(-0.70f,0.20f,1.30f),
new Vector3(-0.50f,0.20f,1.30f),
new Vector3(-0.50f,0.60f,1.30f),
new Vector3(-0.70f,0.60f,1.30f),
Color.Black),

new Quad(new Vector3(1.00f,0.60f,1.50f),
new Vector3(1.00f,1.50f,1.50f),
new Vector3(-1.00f,1.50f,1.50f),
new Vector3(-1.00f,0.60f,1.50f),
Color.Black),

new Quad(new Vector3(-1.00f,1.50f,1.50f),
new Vector3(-1.00f,2.60f,0.50f),
new Vector3(-1.00f,2.60f,-0.50f),
new Vector3(-1.00f,1.50f,-0.50f),
Color.Black),

new Quad(new Vector3(1.00f,0.60f,1.50f),
new Vector3(-1.00f,0.60f,1.50f),
new Vector3(-1.00f,0.60f,-0.50f),
new Vector3(1.00f,0.60f,-0.50f),
Color.Black),

new Quad(new Vector3(-0.09f,1.58f,-2.50f),
new Vector3(0.09f,1.58f,-2.50f),
new Vector3(0.09f,1.58f,-3.50f),
new Vector3(-0.09f,1.58f,-3.50f),
Color.Black),

new Quad(new Vector3(1.00f,2.60f,0.50f),
new Vector3(-1.00f,2.60f,0.50f),
new Vector3(-1.00f,1.50f,1.50f),
new Vector3(1.00f,1.50f,1.50f),
Color.Black),

new Quad(new Vector3(-0.09f,0.62f,-2.50f),
new Vector3(0.09f,0.62f,-2.50f),
new Vector3(0.09f,1.58f,-2.50f),
new Vector3(-0.09f,1.58f,-2.50f),
Color.Black),

new Quad(new Vector3(-0.30f,1.40f,-0.50f),
new Vector3(0.30f,1.40f,-0.50f),
new Vector3(0.09f,1.40f,-2.50f),
new Vector3(-0.09f,1.40f,-2.50f),
Color.Black),

new Quad(new Vector3(-0.09f,0.80f,-3.30f),
new Vector3(-0.09f,0.80f,-2.70f),
new Vector3(0.00f,0.80f,-2.70f),
new Vector3(0.00f,0.80f,-3.30f),
Color.Black),

new Quad(new Vector3(0.09f,0.62f,-2.50f),
new Vector3(-0.09f,0.62f,-2.50f),
new Vector3(-0.09f,0.62f,-3.50f),
new Vector3(0.09f,0.62f,-3.50f),
Color.Black),

new Quad(new Vector3(-0.09f,1.40f,-2.70f),
new Vector3(-0.09f,0.80f,-2.70f),
new Vector3(-0.09f,0.62f,-2.50f),
new Vector3(-0.09f,1.58f,-2.50f),
Color.Black),

new Quad(new Vector3(-0.09f,0.80f,-3.30f),
new Vector3(-0.09f,1.40f,-3.30f),
new Vector3(-0.09f,1.58f,-3.50f),
new Vector3(-0.09f,0.62f,-3.50f),
Color.Black),

new Quad(new Vector3(-0.09f,0.80f,-2.70f),
new Vector3(-0.09f,0.80f,-3.30f),
new Vector3(-0.09f,0.62f,-3.50f),
new Vector3(-0.09f,0.62f,-2.50f),
Color.Black),

new Quad(new Vector3(-0.09f,1.40f,-3.30f),
new Vector3(-0.09f,1.40f,-2.70f),
new Vector3(-0.09f,1.58f,-2.50f),
new Vector3(-0.09f,1.58f,-3.50f),
Color.Black),

new Quad(new Vector3(-0.09f,0.80f,-2.70f),
new Vector3(-0.09f,1.40f,-2.70f),
new Vector3(0.00f,1.40f,-2.70f),
new Vector3(0.00f,0.80f,-2.70f),
Color.Black),

new Quad(new Vector3(-0.09f,1.40f,-2.70f),
new Vector3(-0.09f,1.40f,-3.30f),
new Vector3(0.00f,1.40f,-3.30f),
new Vector3(0.00f,1.40f,-2.70f),
Color.Black),

new Quad(new Vector3(-0.09f,1.40f,-3.30f),
new Vector3(-0.09f,0.80f,-3.30f),
new Vector3(0.00f,0.80f,-3.30f),
new Vector3(0.00f,1.40f,-3.30f),
Color.Black),

new Quad(new Vector3(0.50f,-0.00f,1.50f),
new Vector3(0.70f,-0.00f,1.50f),
new Vector3(0.70f,0.20f,1.50f),
new Vector3(0.50f,0.20f,1.50f),
Color.Black),

new Quad(new Vector3(0.70f,-0.00f,1.50f),
new Vector3(0.70f,0.00f,-0.50f),
new Vector3(0.70f,0.20f,-0.50f),
new Vector3(0.70f,0.20f,1.50f),
Color.Black),

new Quad(new Vector3(0.50f,0.20f,-0.30f),
new Vector3(0.50f,0.60f,-0.30f),
new Vector3(0.70f,0.60f,-0.30f),
new Vector3(0.70f,0.20f,-0.30f),
Color.Black),

new Quad(new Vector3(0.70f,0.00f,-0.50f),
new Vector3(0.50f,0.00f,-0.50f),
new Vector3(0.50f,0.20f,-0.50f),
new Vector3(0.70f,0.20f,-0.50f),
Color.Black),

new Quad(new Vector3(0.50f,0.00f,-0.50f),
new Vector3(0.70f,0.00f,-0.50f),
new Vector3(0.70f,-0.00f,1.50f),
new Vector3(0.50f,-0.00f,1.50f),
Color.Black),

new Quad(new Vector3(0.50f,-0.00f,1.50f),
new Vector3(0.50f,0.20f,1.50f),
new Vector3(0.50f,0.20f,-0.50f),
new Vector3(0.50f,0.00f,-0.50f),
Color.Black),

new Quad(new Vector3(0.50f,0.20f,1.50f),
new Vector3(0.70f,0.20f,1.50f),
new Vector3(0.70f,0.20f,-0.50f),
new Vector3(0.50f,0.20f,-0.50f),
Color.Black),

new Quad(new Vector3(0.70f,0.20f,1.00f),
new Vector3(0.70f,0.60f,1.00f),
new Vector3(0.70f,0.60f,1.30f),
new Vector3(0.70f,0.20f,1.30f),
Color.Black),

new Quad(new Vector3(0.30f,0.80f,-0.50f),
new Vector3(0.09f,0.80f,-2.50f),
new Vector3(0.09f,1.40f,-2.50f),
new Vector3(0.30f,1.40f,-0.50f),
Color.Black),

new Quad(new Vector3(0.50f,0.20f,1.00f),
new Vector3(0.50f,0.60f,1.00f),
new Vector3(0.70f,0.60f,1.00f),
new Vector3(0.70f,0.20f,1.00f),
Color.Black),

new Quad(new Vector3(0.50f,0.20f,0.00f),
new Vector3(0.50f,0.60f,0.00f),
new Vector3(0.50f,0.60f,-0.30f),
new Vector3(0.50f,0.20f,-0.30f),
Color.Black),

new Quad(new Vector3(0.70f,0.20f,-0.30f),
new Vector3(0.70f,0.60f,-0.30f),
new Vector3(0.70f,0.60f,0.00f),
new Vector3(0.70f,0.20f,0.00f),
Color.Black),

new Quad(new Vector3(0.50f,0.20f,1.30f),
new Vector3(0.50f,0.60f,1.30f),
new Vector3(0.50f,0.60f,1.00f),
new Vector3(0.50f,0.20f,1.00f),
Color.Black),

new Quad(new Vector3(0.70f,0.20f,0.00f),
new Vector3(0.70f,0.60f,0.00f),
new Vector3(0.50f,0.60f,0.00f),
new Vector3(0.50f,0.20f,0.00f),
Color.Black),

new Quad(new Vector3(0.70f,0.20f,1.30f),
new Vector3(0.70f,0.60f,1.30f),
new Vector3(0.50f,0.60f,1.30f),
new Vector3(0.50f,0.20f,1.30f),
Color.Black),

new Quad(new Vector3(1.00f,2.60f,-0.50f),
new Vector3(1.00f,2.60f,0.50f),
new Vector3(1.00f,1.50f,1.50f),
new Vector3(1.00f,1.50f,-0.50f),
Color.Black),

new Quad(new Vector3(0.09f,0.80f,-3.30f),
new Vector3(0.00f,0.80f,-3.30f),
new Vector3(0.00f,0.80f,-2.70f),
new Vector3(0.09f,0.80f,-2.70f),
Color.Black),

new Quad(new Vector3(0.09f,1.40f,-2.70f),
new Vector3(0.09f,1.58f,-2.50f),
new Vector3(0.09f,0.62f,-2.50f),
new Vector3(0.09f,0.80f,-2.70f),
Color.Black),

new Quad(new Vector3(0.09f,0.80f,-3.30f),
new Vector3(0.09f,0.62f,-3.50f),
new Vector3(0.09f,1.58f,-3.50f),
new Vector3(0.09f,1.40f,-3.30f),
Color.Black),

new Quad(new Vector3(0.09f,0.80f,-2.70f),
new Vector3(0.09f,0.62f,-2.50f),
new Vector3(0.09f,0.62f,-3.50f),
new Vector3(0.09f,0.80f,-3.30f),
Color.Black),

new Quad(new Vector3(0.09f,1.40f,-3.30f),
new Vector3(0.09f,1.58f,-3.50f),
new Vector3(0.09f,1.58f,-2.50f),
new Vector3(0.09f,1.40f,-2.70f),
Color.Black),

new Quad(new Vector3(0.09f,0.80f,-2.70f),
new Vector3(0.00f,0.80f,-2.70f),
new Vector3(0.00f,1.40f,-2.70f),
new Vector3(0.09f,1.40f,-2.70f),
Color.Black),

new Quad(new Vector3(0.09f,1.40f,-2.70f),
new Vector3(0.00f,1.40f,-2.70f),
new Vector3(0.00f,1.40f,-3.30f),
new Vector3(0.09f,1.40f,-3.30f),
Color.Black),

new Quad(new Vector3(0.09f,1.40f,-3.30f),
new Vector3(0.00f,1.40f,-3.30f),
new Vector3(0.00f,0.80f,-3.30f),
new Vector3(0.09f,0.80f,-3.30f),
Color.Black),

new Quad(new Vector3(-1.00f,0.60f,-0.50f),
new Vector3(-1.00f,0.60f,1.50f),
new Vector3(-1.00f,1.50f,1.50f),
new Vector3(-1.00f,1.50f,-0.50f),
Color.Black),

new Quad(new Vector3(1.00f,1.50f,1.50f),
new Vector3(1.00f,0.60f,1.50f),
new Vector3(1.00f,0.60f,-0.50f),
new Vector3(1.00f,1.50f,-0.50f),
Color.Black), 
	#endregion
            };

            List<Quad> heliMainBlade = new List<Quad>
            {
                #region main blades
                new Quad(new Vector3(0.06f,0.10f,0.06f),
new Vector3(0.06f,0.10f,-0.06f),
new Vector3(0.06f,0.20f,-0.06f),
new Vector3(0.06f,0.20f,0.06f),
Color.Green),

new Quad(new Vector3(-0.06f,-0.00f,-0.06f),
new Vector3(-0.06f,0.10f,-0.06f),
new Vector3(0.06f,0.10f,-0.06f),
new Vector3(0.06f,-0.00f,-0.06f),
Color.Green),

new Quad(new Vector3(-0.06f,-0.00f,0.06f),
new Vector3(-0.06f,0.10f,0.06f),
new Vector3(-0.06f,0.10f,-0.06f),
new Vector3(-0.06f,-0.00f,-0.06f),
Color.Green),

new Quad(new Vector3(0.06f,-0.00f,0.06f),
new Vector3(0.06f,0.10f,0.06f),
new Vector3(-0.06f,0.10f,0.06f),
new Vector3(-0.06f,-0.00f,0.06f),
Color.Green),

new Quad(new Vector3(0.06f,-0.00f,-0.06f),
new Vector3(0.06f,0.10f,-0.06f),
new Vector3(0.06f,0.10f,0.06f),
new Vector3(0.06f,-0.00f,0.06f),
Color.Green),

new Quad(new Vector3(-0.06f,0.20f,0.06f),
new Vector3(0.06f,0.20f,0.06f),
new Vector3(0.06f,0.20f,-0.06f),
new Vector3(-0.06f,0.20f,-0.06f),
Color.Green),

new Quad(new Vector3(0.06f,0.10f,-0.06f),
new Vector3(-0.06f,0.10f,-0.06f),
new Vector3(-0.06f,0.20f,-0.06f),
new Vector3(0.06f,0.20f,-0.06f),
Color.Green),

new Quad(new Vector3(-0.06f,0.10f,0.06f),
new Vector3(0.06f,0.10f,0.06f),
new Vector3(0.06f,0.20f,0.06f),
new Vector3(-0.06f,0.20f,0.06f),
Color.Green),

new Quad(new Vector3(-0.06f,0.10f,-0.06f),
new Vector3(-0.06f,0.10f,0.06f),
new Vector3(-0.06f,0.20f,0.06f),
new Vector3(-0.06f,0.20f,-0.06f),
Color.Green),

new Quad(new Vector3(-0.06f,0.10f,0.06f),
new Vector3(-0.06f,0.10f,-0.06f),
new Vector3(-3.00f,0.10f,-0.06f),
new Vector3(-3.00f,0.10f,0.06f),
Color.Green),

new Quad(new Vector3(-0.06f,0.10f,-3.00f),
new Vector3(-0.06f,0.10f,-0.06f),
new Vector3(0.06f,0.10f,-0.06f),
new Vector3(0.06f,0.10f,-3.00f),
Color.Green),

new Quad(new Vector3(0.06f,0.10f,-0.06f),
new Vector3(0.06f,0.10f,0.06f),
new Vector3(3.00f,0.10f,0.06f),
new Vector3(3.00f,0.10f,-0.06f),
Color.Green),

new Quad(new Vector3(0.06f,0.10f,3.00f),
new Vector3(0.06f,0.10f,0.06f),
new Vector3(-0.06f,0.10f,0.06f),
new Vector3(-0.06f,0.10f,3.00f),
Color.Green),
                #endregion
            };

            List<Quad> heliTailBlade = new List<Quad>()
            {
                #region tail blades
                new Quad(new Vector3(-0.03f,0.02f,-0.02f),
new Vector3(-0.03f,0.02f,0.02f),
new Vector3(-0.03f,0.20f,0.02f),
new Vector3(-0.03f,0.20f,-0.02f),
Color.Green),

new Quad(new Vector3(-0.03f,-0.02f,-0.02f),
new Vector3(-0.03f,0.02f,-0.02f),
new Vector3(-0.03f,0.02f,-0.20f),
new Vector3(-0.03f,-0.02f,-0.20f),
Color.Green),

new Quad(new Vector3(0.00f,0.02f,0.02f),
new Vector3(0.00f,-0.02f,0.02f),
new Vector3(0.00f,-0.02f,-0.02f),
new Vector3(0.00f,0.02f,-0.02f),
Color.Green),

new Quad(new Vector3(-0.03f,0.02f,0.02f),
new Vector3(-0.03f,0.02f,-0.02f),
new Vector3(-0.06f,0.02f,-0.02f),
new Vector3(-0.06f,0.02f,0.02f),
Color.Green),

new Quad(new Vector3(0.00f,-0.02f,-0.02f),
new Vector3(-0.03f,-0.02f,-0.02f),
new Vector3(-0.03f,0.02f,-0.02f),
new Vector3(0.00f,0.02f,-0.02f),
Color.Green),

new Quad(new Vector3(0.00f,-0.02f,0.02f),
new Vector3(-0.03f,-0.02f,0.02f),
new Vector3(-0.03f,-0.02f,-0.02f),
new Vector3(0.00f,-0.02f,-0.02f),
Color.Green),

new Quad(new Vector3(0.00f,0.02f,0.02f),
new Vector3(-0.03f,0.02f,0.02f),
new Vector3(-0.03f,-0.02f,0.02f),
new Vector3(0.00f,-0.02f,0.02f),
Color.Green),

new Quad(new Vector3(0.00f,0.02f,-0.02f),
new Vector3(-0.03f,0.02f,-0.02f),
new Vector3(-0.03f,0.02f,0.02f),
new Vector3(0.00f,0.02f,0.02f),
Color.Green),

new Quad(new Vector3(-0.03f,-0.02f,0.02f),
new Vector3(-0.03f,-0.02f,-0.02f),
new Vector3(-0.03f,-0.20f,-0.02f),
new Vector3(-0.03f,-0.20f,0.02f),
Color.Green),

new Quad(new Vector3(-0.03f,-0.02f,0.02f),
new Vector3(-0.03f,0.02f,0.02f),
new Vector3(-0.03f,0.02f,0.20f),
new Vector3(-0.03f,-0.02f,0.20f),
Color.Green),

new Quad(new Vector3(-0.06f,-0.02f,0.02f),
new Vector3(-0.06f,0.02f,0.02f),
new Vector3(-0.06f,0.02f,-0.02f),
new Vector3(-0.06f,-0.02f,-0.02f),
Color.Green),

new Quad(new Vector3(-0.03f,0.02f,-0.02f),
new Vector3(-0.03f,-0.02f,-0.02f),
new Vector3(-0.06f,-0.02f,-0.02f),
new Vector3(-0.06f,0.02f,-0.02f),
Color.Green),

new Quad(new Vector3(-0.03f,-0.02f,0.02f),
new Vector3(-0.03f,0.02f,0.02f),
new Vector3(-0.06f,0.02f,0.02f),
new Vector3(-0.06f,-0.02f,0.02f),
Color.Green),

new Quad(new Vector3(-0.03f,-0.02f,-0.02f),
new Vector3(-0.03f,-0.02f,0.02f),
new Vector3(-0.06f,-0.02f,0.02f),
new Vector3(-0.06f,-0.02f,-0.02f),
Color.Green),
                #endregion
            };
            chooper.AddQuads(heliBody); // adicionar a lista de poligonos
            chooper.SetPosition(0, 1.5f, 0.5f); // setar posicao do helicoptero
            chooper.SetMainBlade(0, 4.1f, 0.5f, heliMainBlade); // adicionar helices e setar posicoes
            chooper.SetTailBlade(0, 2.6f, -2.5f, heliTailBlade); 
            #endregion

            Obj casa = new Obj();
            #region set da casa
            List<Quad> houseBody = new List<Quad>
            {
                #region House All Quads
                new Quad(new Vector3(-1.50f,1.00f,2.75f),
new Vector3(-1.50f,1.00f,0.75f),
new Vector3(-1.50f,-0.00f,0.75f),
new Vector3(-1.50f,-0.00f,2.75f),
Color.Yellow),

new Quad(new Vector3(-1.50f,3.00f,-3.75f),
new Vector3(-1.50f,2.00f,-3.75f),
new Vector3(-1.50f,2.00f,3.75f),
new Vector3(-1.50f,3.00f,3.75f),
Color.Yellow),

new Quad(new Vector3(-1.50f,2.00f,-1.10f),
new Vector3(-1.50f,1.30f,-1.10f),
new Vector3(-1.50f,1.30f,0.75f),
new Vector3(-1.50f,2.00f,0.75f),
Color.Yellow),

new Quad(new Vector3(-1.50f,0.00f,-3.75f),
new Vector3(-1.50f,3.00f,-3.75f),
new Vector3(1.30f,3.00f,-3.75f),
new Vector3(1.30f,0.00f,-3.75f),
Color.Yellow),

new Quad(new Vector3(-1.50f,1.30f,-1.80f),
new Vector3(-1.50f,2.00f,-1.80f),
new Vector3(-1.50f,2.00f,-3.75f),
new Vector3(-1.50f,1.30f,-3.75f),
Color.Yellow),

new Quad(new Vector3(-1.50f,2.00f,3.75f),
new Vector3(-1.50f,2.00f,2.75f),
new Vector3(-1.50f,-0.00f,2.75f),
new Vector3(-1.50f,0.00f,3.75f),
Color.Yellow),

new Quad(new Vector3(-1.50f,1.30f,0.75f),
new Vector3(-1.50f,1.30f,-3.75f),
new Vector3(-1.50f,0.00f,-3.75f),
new Vector3(-1.50f,-0.00f,0.75f),
Color.Yellow),

new Quad(new Vector3(1.30f,1.80f,1.40f),
new Vector3(1.30f,1.80f,-1.10f),
new Vector3(1.30f,2.00f,-1.10f),
new Vector3(1.30f,2.00f,1.40f),
Color.Yellow),

new Quad(new Vector3(1.30f,1.80f,1.40f),
new Vector3(1.30f,-0.00f,1.40f),
new Vector3(1.30f,0.00f,-1.80f),
new Vector3(1.30f,1.80f,-1.80f),
Color.Yellow),

new Quad(new Vector3(1.30f,-0.00f,2.10f),
new Vector3(1.30f,-0.00f,1.40f),
new Vector3(1.30f,1.30f,1.40f),
new Vector3(1.30f,1.30f,2.10f),
Color.Yellow),

new Quad(new Vector3(0.51f,2.00f,3.75f),
new Vector3(0.51f,-0.01f,3.75f),
new Vector3(1.30f,0.00f,3.75f),
new Vector3(1.30f,2.00f,3.75f),
Color.Yellow),

new Quad(new Vector3(1.30f,2.00f,-1.80f),
new Vector3(1.30f,0.00f,-1.80f),
new Vector3(1.30f,0.00f,-3.75f),
new Vector3(1.30f,2.00f,-3.75f),
Color.Yellow),

new Quad(new Vector3(1.30f,3.00f,3.75f),
new Vector3(1.30f,2.00f,3.75f),
new Vector3(1.30f,2.00f,-3.75f),
new Vector3(1.30f,3.00f,-3.75f),
Color.Yellow),

new Quad(new Vector3(1.30f,3.00f,-3.75f),
new Vector3(-1.50f,3.00f,-3.75f),
new Vector3(-1.50f,3.00f,3.75f),
new Vector3(1.30f,3.00f,3.75f),
Color.Yellow),

new Quad(new Vector3(1.30f,3.00f,3.75f),
new Vector3(-1.50f,3.00f,3.75f),
new Vector3(-1.50f,2.00f,3.75f),
new Vector3(1.30f,2.00f,3.75f),
Color.Yellow),

new Quad(new Vector3(-1.50f,0.00f,3.75f),
new Vector3(-0.79f,-0.01f,3.75f),
new Vector3(-0.79f,1.99f,3.75f),
new Vector3(-1.50f,2.00f,3.75f),
Color.Yellow),

new Quad(new Vector3(1.30f,2.00f,2.10f),
new Vector3(1.30f,2.00f,3.75f),
new Vector3(1.30f,0.00f,3.75f),
new Vector3(1.30f,-0.00f,2.10f),
Color.Yellow),
                #endregion
            };

            Obj misc = new Obj();
            List<Quad> doorja = new List<Quad>
            {
                #region Portas e janelas
                new Quad(new Vector3(1.30f,1.80f,-1.10f),
new Vector3(1.30f,1.80f,-1.80f),
new Vector3(1.30f,2.00f,-1.80f),
new Vector3(1.30f,2.00f,-1.10f),
Color.Red),

new Quad(new Vector3(1.30f,1.30f,2.10f),
new Vector3(1.30f,1.30f,1.40f),
new Vector3(1.30f,2.00f,1.40f),
new Vector3(1.30f,2.00f,2.10f),
Color.Red),

new Quad(new Vector3(-1.50f,2.00f,1.75f),
new Vector3(-1.50f,2.00f,0.75f),
new Vector3(-1.50f,1.00f,0.75f),
new Vector3(-1.50f,1.00f,1.75f),
Color.Red),

new Quad(new Vector3(-1.50f,2.00f,-1.80f),
new Vector3(-1.50f,1.30f,-1.80f),
new Vector3(-1.50f,1.30f,-1.10f),
new Vector3(-1.50f,2.00f,-1.10f),
Color.Red),

new Quad(new Vector3(-1.50f,1.00f,1.75f),
new Vector3(-1.50f,1.00f,2.75f),
new Vector3(-1.50f,2.00f,2.75f),
new Vector3(-1.50f,2.00f,1.75f),
Color.Red),

new Quad(new Vector3(-0.79f,1.99f,3.75f),
new Vector3(-0.79f,-0.01f,3.75f),
new Vector3(0.51f,-0.01f,3.75f),
new Vector3(0.51f,1.99f,3.75f),
Color.Red),
                #endregion
            };
            casa.AddQuads(houseBody);
            casa.AddQuads(doorja);
            casa.SetPosition(0.1f, -1.5f, 0); 
            #endregion

            Obj chao = new Obj(
            #region set do chao
new List<Quad> 
                    { 
                        new Quad(
                            new Vector3(8.5f,0,-9),
                            new Vector3(8.5f,0,9),
                            new Vector3(-8.5f,0,9),
                            new Vector3(-8.5f,0,-9), Color.Brown)
                    }
                );
            chao.SetPosition(0, -1.5f, 0);
            #endregion

            //TODO: Create sets
            //TODO: Include objects on set
            List<Obj> pimba = new List<Obj> 
            {
                casa,
                chooper,
                chao
            };

            //TODO: Create scenes
            //TODO: Insert the set of objects on scene
            actualScene = new Scene(pimba, "Cena 1");

            //TODO: add the scences
            scenes = new List<Scene>();
            scenes.Add(actualScene);
        }

        public static void Update(GameTime gameTime)
        {
            //TODO: Logic to update a scene
            actualScene.Update(gameTime);
        }

        public static void Draw()
        {
            //TODO: Logic to draw a scene
            actualScene.Draw(camera);
        }

        public static GraphicsDevice GetDevice()
        {
            return staticDevice;
        }
    }
}
