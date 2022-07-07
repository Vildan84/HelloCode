int count = 0;
int distance = 200;
int FirstFriendSpeed = 5;
int SecondFriendSpeed = 7;
int DogSpeed = 10;
int friend = 2;
int time = 0;

while(distance > 10)
{
    if(friend == 2)
    {
        time = distance / (SecondFriendSpeed + DogSpeed);
        friend = 1;
    }
    else
    {
        time = distance / (FirstFriendSpeed + DogSpeed);
        friend = 2;
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count += 1;
Console.WriteLine(count);

}




