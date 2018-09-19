#region using
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
#endregion

namespace Mundo3.Objects
{
    class Quad
    {
        Triangle superior;
        Triangle inferior;

        public Quad() { }

        /// <summary>
        /// Cria um retangulo formado por 2 triangulos. Comecar do ponto inferior esquerdo
        /// e terminar no ponto inferior direito
        /// </summary>
        /// <param name="device">Graphic Device</param>
        /// <param name="p1">ponto inferior esquerdo</param>
        /// <param name="p2">ponto superior esquerdo</param>
        /// <param name="p3">ponto superior direito</param>
        /// <param name="p4">ponto inferior direito</param>
        public Quad(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, Color color = default(Color))
        {
            if (object.Equals(color, default(Color)))
            {
                superior = new Triangle(p1, p2, p3);
                inferior = new Triangle(p1, p4, p3);
            }
            else
            {
                superior = new Triangle(p1, p2, p3, color);
                inferior = new Triangle(p1, p4, p3, color);
            }
        }

        /// <summary>
        /// Cria um retangulo a partir de um ponto inicial
        /// Up - Direcao da altura
        /// Forward - direcao da largura
        /// So serve para retangulos posicionados em angulos retos
        /// </summary>
        /// <param name="device">Graphic Device</param>
        /// <param name="height">Altura do retangulo</param>
        /// <param name="width">Comprimento do retangulo</param>
        /// <param name="startPoint">Ponto inicial (ponta esquerda inferior)</param>
        /// <param name="up">Direcao da altura</param>
        /// <param name="forward">Direção do comprimento</param>
        /// <param name="color"></param>
        public Quad(float height, float width, Vector3 startPoint, Vector3 up, Vector3 forward, Color color = default(Color))
        {
            if (object.Equals(color, default(Color)))
            {
                up.Normalize();
                forward.Normalize();

                superior = new Triangle(startPoint, startPoint + (up * height), startPoint + (up * height) + (forward * width));
                inferior = new Triangle(startPoint, startPoint + (up * width) + (forward * height), startPoint + (forward * width));
            }
            else
            {
                up.Normalize();
                forward.Normalize();

                superior = new Triangle(startPoint, startPoint + (up * height), startPoint + (up * height) + (forward * width), color);
                inferior = new Triangle(startPoint, startPoint + (up * width) + (forward * height), startPoint + (forward * width), color);
            }
        }

        public void Draw(Camera camera)
        {
            superior.Draw(camera);
            inferior.Draw(camera);
        }

        public void Translate(Vector3 move)
        {
            superior.Translate(move);
            inferior.Translate(move);
        }

        public void Rotate(Vector3 arround, float angle)
        {
            superior.Rotate(arround, angle);
            inferior.Rotate(arround, angle);
        }

        public void SetIdentity()
        {
            superior.SetIdentity();
            inferior.SetIdentity();
        }

        public void SetColor(Color color)
        {
            superior.SetColor(color);
            inferior.SetColor(color);
        }
    }
}
