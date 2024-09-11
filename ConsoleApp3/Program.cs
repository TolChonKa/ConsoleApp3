
Console.Write("Введите кол-во денег: ");
decimal sum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во месяцев: ");
int month = Convert.ToInt32(Console.ReadLine());
decimal result = sum * Convert.ToDecimal (0.07);
decimal global_result;
for (int i = 0; i!= month  ; i++ )
{
    
    global_result = sum + result;
    sum = global_result;


}
Console.WriteLine($"Ваша сумма по вкладу составит: {global_result}");
Console.ReadLine();