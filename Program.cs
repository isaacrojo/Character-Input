using System;

namespace P_4_Character_input
{
    class Program
    {
        static int posX = 0;
        static int posY = 0;
        static string lastPosPressed = "";

        //arriba
        static void PressUp() {
            if(lastPosPressed == ""){
               lastPosPressed = "up"; 
            }
            
        }
        static void ReleaseUp(){
            if (lastPosPressed == "up"){
             //mover hacia arriba
              posY--;   
              lastPosPressed = "";
            }
           
        }

        //abajo
        static void PressDown() {
            if(lastPosPressed == ""){
               lastPosPressed = "down"; 
            }
            
        }
        static void ReleaseDown(){
            if (lastPosPressed == "down"){
             //mover hacia arriba
              posY++;   
              lastPosPressed = "";
            }
           
        }

        //izquierda
        static void PressLeft() {
            if(lastPosPressed == ""){
               lastPosPressed = "left"; 
            }
            
        }
        static void ReleaseLeft(){
            if (lastPosPressed == "left"){
             //mover hacia arriba
              posX--;   
              lastPosPressed = "";
            }
           
        }

        //derecha
        static void PressRight() {
            if(lastPosPressed == ""){
               lastPosPressed = "right"; 
            }
            
        }
        static void ReleaseRight(){
            if (lastPosPressed == "right"){
             //mover hacia arriba
              posX++;   
              lastPosPressed = "";
            }
           
        }
        static void Main(string[] args)
        {
            for(posX = 0; posX < 499; posX++)
            



            //move up
            PressUp();
            ReleaseUp();
            for(posY = 0; posY < 500; posY++)
            //move right
            PressRight();
           // PressDown();           //se omite, right is already pressed
            ReleaseRight();
           
           //move right
           // PressRight();
            //ReleaseRight();
            
            Console.WriteLine(posX + "," + posY);
        }
    }
}
