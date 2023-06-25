Public Class HealthyEatingMealPrep
    
    ' Declare variables
    Private mealspace As String
    Private mealtype As String
    Private mealitems As String
    Private mealprep As String
    Private mealprepTime As Integer
    Private mealoptions As String
    Private label As String
    Private healthyOptions As String
    Private mealplanning As String
    Private EatingPlan As String
    Private mealprepdays As Integer
    Private i As Integer
    
    ' Create a method to plan a healthy eating strategy
    Public Sub EatingStrategy()
        label = "Healthy Eating and Meal Prep"
        healthyOptions = "Whole grains, vegetables, lean proteins, healthy fats"
        mealplanning = "Planning your meals ahead of time and making sure you have healthy options"
        EatingPlan = "Create a schedule and plan your meals by breakfast, lunch, dinner"
        mealprepdays = 7
        mealspace = "at least two hours"
        mealtype = "balanced meals for the day"
        mealitems = "lean proteins, vegetables, fruits and whole grains"
        mealprep = "Prepare meals on the weekend for the week"
        mealprepTime = 2
        
        Console.WriteLine(label)
        Console.WriteLine("-------------------------------------------------")
        Console.WriteLine("In order to eat healthier, choose healthy food options such as " + healthyOptions)
        Console.WriteLine("Meal planning is essential to a healthy diet, which includes " + mealplanning)
        Console.WriteLine("Creating a weekly eating plan by " + EatingPlan)
        Console.WriteLine("For a balanced meal, create " + mealprepdays + " days' worth of " + mealtype + ", that includes " + mealitems + ".")
        Console.WriteLine("To make sure you are prepared for the week, " + mealprep + " and set aside " + mealprepTime + " hours for it.")
        Console.WriteLine("When you are eating your meals, give yourself " + mealspace + " between each one.")
    End Sub
    
    ' Create a different method to plan meals for the week
    Public Sub MealPlan()
        Console.WriteLine("Meal Planning for the Week")
        Console.WriteLine("---------------------------------------------------")
        Do While(i < mealprepdays)
            Console.WriteLine("Day " + i + ":")
            Console.WriteLine("Breakfast:____")
            Console.WriteLine("Lunch:_____")
            Console.WriteLine("Dinner:____")
            Console.WriteLine("Snack:_____")
            Console.WriteLine("")
            i = i + 1
        Loop
    End Sub
    
    ' Create a different meal options
    Public Sub MealOptions()
        Console.WriteLine("Meal Options")
        Console.WriteLine("------------------------------------------------")
        mealoptions = "Salad, Soup, Sandwich, Omelette, Veggie Burger, Smoothie, Vegetable Stir Fry"
        Console.WriteLine(mealoptions)
    End Sub
    
End Class