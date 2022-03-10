﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_Array_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //예약, 예약 확인, 취소
            string[,] seat = new string[3, 5];

            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    seat[i, j] = "___";
                }
            }
            /*
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    Console.WriteLine(seat[i, j]);
                }
            }
            */

            //예매
            seat[2, 1] = "홍길동";
            seat[0, 0] = "김유신";
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    Console.Write(seat[i, j] == "___" ? "\t[빈 좌석]" : "\t[ 예 매 ]");
                }
                Console.WriteLine("\n");
            }

            //int row, col;
            //예매 시작
            Console.Write("예매하고 싶은 좌석을 선택해주세요: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("예매하고 싶은 좌석을 선택해주세요: ");
            int col = int.Parse(Console.ReadLine());

            //[0, 0] 예매 하겠다
            //row = 0;
            //col = 0;

            if (seat[row, col] == "___")
            {
                Console.WriteLine("예약 가능한 좌석입니다.");
            }
            else
            {
                Console.WriteLine("이미 예약된 좌석입니다.");
            }

            //좌석 초기화
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    seat[i, j] = "___";
                }
            }

            //초기화 확인
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    Console.Write(seat[i, j] == "___" ? "\t[빈 좌석]" : "\t[ 예 매 ]");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
