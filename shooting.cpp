#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<windows.h>
#include<time.h>
#include<ctime>

using namespace std;

COORD coord={0,0};

 void gotoxy(int x,int y)
 {
    coord.X=x;
    coord.Y=y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),coord);
 }

int main(int args, char* argv[])
{
    X:
        //clock_t start_time, end_time, int_time;
        //start_time = clock();
        system("TITLE SHOOTING GAME SIMULATOR");
        int k=0,x,y,score = 0,turns;
        system("COLOR 9A");
        FILE *f;
        if(args == 1)
        {
            f = fopen("coord.txt","r");
        }
        else
        {
            f = fopen(argv[1],"r");
        }
        while(!feof(f))
        {
            int j = 1;
            fscanf(f,"%d %d",&x,&y);
            for(int i=0,k=0;i<69;)
            {
                time_t start = clock();
                //int_time = clock();
                printf("\n\n\n\t\tCONTROLS\t\t   W\n");
                printf("\t\t\t\t         A S D\t\tAIM : SPACE BAR\n\n");
                printf("------------------------------------------------------------------------------\n");
                for(int l=0;l<k;l++)
                    printf("\n");
                //printf("\n\n\n\n\n");
                for(int j=0;j<=i;j++)
                printf(" ");
                printf("  _____\n");
                for(int j=0;j<=i;j++)
                    printf(" ");
                printf(" /     \\\n");
                for(int j=0;j<=i;j++)
                    printf(" ");
                printf("/   .   \\");
                for(int j=i;j<69;j++)
                    printf(" ");
                printf("\n");
                for(int j=0;j<=i;j++)
                    printf(" ");
                printf("\\       /\n");
                for(int j=0;j<=i;j++)
                    printf(" ");
                    printf(" \\_____/\n\n\n\t");
                //_sleep(50);
                gotoxy(x+5,y+9);
                printf("*");
                char a = getch();
                //end_time = clock();
                /*/*if((int)clock()%1000>=500)
                {
                    fscanf(f,"%d %d",&x,&y);
                }
                if(((int)end_time%20==18 || (int)end_time%20==9 || (int)end_time%20==0 ) && a != ' ')sss
                {
                    fscanf(f,"%d %d",&x,&y);;
                }*/
                /*if((int)difftime(start_time,end_time)%10>=0)
                {
                    fscanf(f,"%d %d",&x,&y);;
                }*/
                time_t end_time = clock() - start;
                if(a == ' ')
                {
                    system("COLOR 7A");
                    _sleep(100);
                    printf("\a");
                    system("COLOR 4A");
                    _sleep(100);
                    system("COLOR 9A");
                    _sleep(100);
                    system("COLOR FA");
                    _sleep(100);
                    system("COLOR 6A");
                    _sleep(100);
                    system("COLOR 7A");
                    _sleep(100);
                    printf("\a");
                    system("COLOR DA");
                    _sleep(100);
                    system("COLOR CA");
                    _sleep(100);
                    system("COLOR 1A");
                    _sleep(100);
                    system("COLOR 7A");
                    _sleep(100);
                    system("COLOR 7A");
                    _sleep(100);
                    printf("\a");
                    system("COLOR 4A");
                    _sleep(100);
                    system("COLOR 9A");
                    _sleep(100);
                    system("COLOR FA");
                    _sleep(100);
                    system("COLOR 6A");
                    _sleep(100);
                    system("COLOR 7A");
                    _sleep(100);
                    printf("\a");
                    system("COLOR DA");
                    _sleep(100);
                    system("COLOR CA");
                    _sleep(100);
                    system("COLOR 1A");
                    _sleep(100);
                    system("COLOR 9A");
                    _sleep(100);
                    if(i==x && k==y)
                    {
                        system("CLS");
                        printf("\n\n\n\n\n\n\n\n\tYOUR AIM WAS SUCCESSFUL\n\n\n\n\t");
                        score++;
                        system("PAUSE");
                        system("CLS");
                        break;
                    }
                    else
                    {
                        system("CLS");
                        system("COLOR 9C");
                        printf("\n\n\n\n\n\n\n\n\tYOUR AIM WAS UNSUCCESSFUL\n\n\n\n\t");
                        system("PAUSE");
                        system("CLS");
                        system("COLOR 9A");
                        break;
                    }
                }
                if(end_time >= 600 || end_time<=200)
                {
                    fscanf(f,"%d %d",&x,&y);
                }
                if(x == 0 && y ==0)
                {
                    goto over;
                }
                if((a == 'd' || a=='D') && i<68)
                        i++;
                else if((a=='a' || a=='A') && i>0)
                        i--;
                else if((a=='w' || a=='W') && k>0)
                        k--;
                else if((a=='S' || a=='s') && k<30)
                        k++;
                if(!((a=='S' || a=='s') || (a=='D' || a=='d') || (a=='w' || a=='W') || (a=='A' || a=='a')))
                {
                    printf("\n\n\n\tINVALID COMMAND : ");
                }
                system("CLS");
            }
                x:
                printf("\n\n\n\n\t\t\tDO YOU WANT TO CONTINUE (Y/N) : ");
                char a = getch();
                printf("%c",a);
                system("CLS");
                if(a=='N' || a=='n')
                    break;
                else if(a=='y' || a=='Y')
                {

                }
                else
                {
                    printf("\n\n\t\t\tINVALID OPTION");
                    goto x;
                }
                j++;
        }
        over:
        Y:
        system("CLS");
        printf("\n\n\n\n\n\t\t\t####################");
        printf("\n\t\t\t#                  #\n\t\t\t#    GAME  OVER    #\n\t\t\t#                  #\n\t\t\t#                  #\n");
        printf("\t\t\t# YOUR SCORE IS %2d #",score);
        printf("\n\t\t\t#                  #\n\t\t\t####################");
        char option;
        printf("\n\n\n\n\t DO YOU WANT TO CONTINUE (Y/N): ");
        option = getch();
        if(option == 'y' || option == 'Y')
        {
            system("CLS");
            goto X;
        }
        else if(option != 'n' && option != 'N')
        {
            goto Y;
        }
        fclose(f);
}

