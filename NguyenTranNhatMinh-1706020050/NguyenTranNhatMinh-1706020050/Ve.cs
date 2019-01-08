/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 1/8/2019
 * Time: 10:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace NguyenTranNhatMinh_1706020050
{
    class Ve
    {
        public List<Point> save = new List<Point>();

        public Ve()
        {

        }
     
        public void LoadData(Dictionary<string, List<Point>> input, string input_Name)
        {
            foreach (var item in input)
            {
                if (item.Key == input_Name)
                {
                    save = item.Value;
                }
            }
        }
        public List<Point> SaveData()
        {
            List<Point> temp = new List<Point>();
            temp = save;
            return temp;
        }
    }
    class Line : Ve
    {
        public Point begin = new Point();
        public Point end = new Point();      
        public Line()
        {
            begin = new Point(0, 0);
            end = new Point(0, 0);
        }
        public Line(Point A, Point B)
        {
            begin = A;
            end = B;
        } 
       
        public  void Draw(Graphics g, Pen pen)
        {
            foreach (var item in save)
            {
                for (int i = 0; i < save.Count - 1; i += 2)
                {
                    g.DrawLine(pen, save[i].x, save[i].y, save[i + 1].x, save[i + 1].y);
                }
            }
        }
        public void AddPoint()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
        }
    }
    class Ellipse : Ve
    {
        public Point begin = new Point();
        public Point end = new Point();         
        public Ellipse()
        {
            begin = new Point(0, 0);
            end = new Point(0, 0);
        }
        public Ellipse(Point A, Point B)
        {
            begin = A;
            end = B;
        }
        public void Draw(Graphics g, Pen pen)
        {
            Rectangle rect = new Rectangle();
            foreach (var item in save)
            {
                for (int i = 0; i < save.Count - 1; i += 2)
                {
                    rect.X = save[i].x;
                    rect.Y = save[i].y;
                    rect.Size = new Size(save[i+1].x - save[i].x, save[i + 1].y - save[i].y);
                    g.DrawEllipse(pen, rect);
                }
            }
        }
        public void AddPoin()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
        }
    }
}