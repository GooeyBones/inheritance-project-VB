Public Class Form1
    'Instantiate Class Members'
    Dim NissanRogue As New roadVehicle
    Dim ToyotaCamry As New roadVehicle
    Dim HondaCRV As New roadVehicle

    Dim Boeing747 As New plane
    Dim Boeing777 As New plane
    Dim Cessna172 As New plane

    'Here's where I test the base class's overloaded constructors - you'll see that I still redefine them below anyway because I tac'd this on last minute'
    Dim OutrageWhaler250 As New waterVehicle("Outrage 250")
    Dim SSXOB267Chaparral As New waterVehicle("SSX OB 267", "Luxury")
    Dim Canyon456GradyWhite As New waterVehicle

    'Load Members Into Respective Object Arrays'
    Dim objArrayCars() As Object = {NissanRogue, ToyotaCamry, HondaCRV}
    Dim objArrayPlanes() As Object = {Boeing747, Boeing777, Cessna172}
    Dim objArrayBoats() As Object = {OutrageWhaler250, SSXOB267Chaparral, Canyon456GradyWhite}

    'Function for generating a string, overloaded'
    Function generateListItem(prop1, prop2, prop3, prop4, prop5)
        Dim genString As String = prop1.ToString.Trim.PadRight(13, " ") + prop2.ToString.PadRight(10, " ") + prop3.ToString.PadRight(13, " ") + prop4.ToString.PadRight(10, " ") + prop5.ToString.PadLeft(5)
        Return genString
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGetInfo.Click
        If cmboCategory.SelectedItem.Equals("Cars") Then
            lstDetailBox.Items.Clear()
            lstDetailBox.Items.Add("There are 3 cars in the Vehicle class:")
            lstDetailBox.Items.Add("Name".PadRight(13, " ") + "Fuel Cap.".PadRight(10, " ") + "Maker".PadRight(10) + "Seating".PadRight(10) + "Horse Power")
            lstDetailBox.Items.Add("----------------------------------------------------------")
            For Each car In objArrayCars
                lstDetailBox.Items.Add(generateListItem(car.VehicleName, car.FuelCapacity, car.Manufacturer, car.SeatingCapacity, car.HorsePower))
            Next

        ElseIf cmboCategory.SelectedItem.Equals("Planes") Then
            lstDetailBox.Items.Clear()
            lstDetailBox.Items.Add("There are 3 planes in the Vehicle class:")
            lstDetailBox.Items.Add("Name".PadRight(13, " ") + "Fuel Cap.".PadRight(10, " ") + "Maker".PadRight(10) + "Seating".PadRight(10) + "Wing Span")
            lstDetailBox.Items.Add("----------------------------------------------------------")
            For Each plane In objArrayPlanes
                lstDetailBox.Items.Add(generateListItem(plane.VehicleName, plane.FuelCapacity, plane.Manufacturer, plane.SeatingCapacity, plane.WingSpan))
            Next

        ElseIf cmboCategory.SelectedItem.Equals("Boats") Then
            lstDetailBox.Items.Clear()
            lstDetailBox.Items.Add("There are 3 boats in the Vehicle class:")
            lstDetailBox.Items.Add("Name".PadRight(13, " ") + "Fuel Cap.".PadRight(10, " ") + "Maker".PadRight(10, " ") + "Seating".PadRight(10, " ") + "Hull Material")
            lstDetailBox.Items.Add("----------------------------------------------------------")
            For Each boat In objArrayBoats
                lstDetailBox.Items.Add(generateListItem(boat.VehicleName, boat.FuelCapacity, boat.Manufacturer, boat.SeatingCapacity, boat.HullMaterial))
            Next

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmboCategory.Items.Add("Cars")
        cmboCategory.Items.Add("Planes")
        cmboCategory.Items.Add("Boats")

        If cmboCategory.Items.Count > 0 Then
            cmboCategory.SelectedIndex = 0
        End If

        'Would probably make a function to do all these with more time'
        'Car Declarations'
        NissanRogue.VehicleName = "Nissan Rogue"
        NissanRogue.VehicleType = "Small SUV"
        NissanRogue.FuelCapacity = 14.5
        NissanRogue.Manufacturer = "Nissan"
        NissanRogue.SeatingCapacity = 5
        NissanRogue.HorsePower = 181

        ToyotaCamry.VehicleName = "Toyota Camry"
        ToyotaCamry.VehicleType = "Sedan"
        ToyotaCamry.FuelCapacity = 15.8
        ToyotaCamry.Manufacturer = "Nissan"
        ToyotaCamry.SeatingCapacity = 5
        ToyotaCamry.HorsePower = 203

        HondaCRV.VehicleName = "Honda CR-V"
        HondaCRV.VehicleType = "Compact Crossover SUV"
        HondaCRV.FuelCapacity = 14.0
        HondaCRV.Manufacturer = "Honda"
        HondaCRV.SeatingCapacity = 5
        HondaCRV.HorsePower = 190

        'Plane Declarations'
        Boeing747.VehicleName = "Boeing 747"
        Boeing747.VehicleType = "Commercial Passenger"
        Boeing747.FuelCapacity = 238840
        Boeing747.Manufacturer = "Boeing"
        Boeing747.SeatingCapacity = 568
        Boeing747.WingSpan = 196

        Boeing777.VehicleName = "Boeing 777"
        Boeing777.VehicleType = "Commercial Passenger"
        Boeing777.FuelCapacity = 117350
        Boeing777.Manufacturer = "Boeing"
        Boeing777.SeatingCapacity = 388
        Boeing777.WingSpan = 212

        Cessna172.VehicleName = "Cessna 172"
        Cessna172.VehicleType = "Personal Plane"
        Cessna172.FuelCapacity = 43
        Cessna172.Manufacturer = "Textron"
        Cessna172.SeatingCapacity = 4
        Cessna172.WingSpan = 36

        'Boat Declarations'
        OutrageWhaler250.VehicleName = "Outrage 250"
        OutrageWhaler250.VehicleType = "Fishing"
        OutrageWhaler250.FuelCapacity = 172
        OutrageWhaler250.Manufacturer = "Boston"
        OutrageWhaler250.SeatingCapacity = 3
        OutrageWhaler250.HullMaterial = "Fiberglass"

        SSXOB267Chaparral.VehicleName = "SSX OB 267"
        SSXOB267Chaparral.VehicleType = "Luxury"
        SSXOB267Chaparral.FuelCapacity = 180
        SSXOB267Chaparral.Manufacturer = "Chaparral"
        SSXOB267Chaparral.SeatingCapacity = 4
        SSXOB267Chaparral.HullMaterial = "Aluminum"

        Canyon456GradyWhite.VehicleName = "Canyon 456"
        Canyon456GradyWhite.VehicleType = "Luxury"
        Canyon456GradyWhite.FuelCapacity = 190
        Canyon456GradyWhite.Manufacturer = "Grady White"
        Canyon456GradyWhite.SeatingCapacity = 4
        Canyon456GradyWhite.HullMaterial = "Fiberglass"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

'Base class, set to MustInherit to make abstract'
Public MustInherit Class Vehicle
    Dim stVehicleName As String
    Dim stVehicleType As String
    Dim dbFuelCapacity As Double
    Dim stVehicleManufacturer As String
    Dim inSeatingCapacity As Integer

    Public Sub New()

    End Sub

    Public Sub New(VehicleName As String)
        Me.VehicleName = VehicleName
    End Sub

    Public Sub New(VehicleName As String, VehicleType As String)
        Me.VehicleName = VehicleName
        Me.VehicleType = VehicleType
    End Sub

    Public Property VehicleName As String
        Set(value As String)
            stVehicleName = value
        End Set
        Get
            Return stVehicleName
        End Get
    End Property
    Public Property VehicleType As String
        Set(veh As String)
            stVehicleType = veh
        End Set
        Get
            Return stVehicleType
        End Get
    End Property

    Public Property FuelCapacity As Double
        Set(cap As Double)
            dbFuelCapacity = cap
        End Set
        Get
            Return dbFuelCapacity
        End Get
    End Property

    Public Property Manufacturer As String
        Set(man As String)
            stVehicleManufacturer = man
        End Set
        Get
            Return stVehicleManufacturer
        End Get
    End Property

    Public Property SeatingCapacity As Integer
        Set(value As Integer)
            inSeatingCapacity = value
        End Set
        Get
            Return inSeatingCapacity
        End Get
    End Property

End Class


Public Class roadVehicle : Inherits Vehicle
    Dim inHorsePower As Integer
    Public Property HorsePower As Integer
        Set(pwr As Integer)
            inHorsePower = pwr
        End Set
        Get
            Return inHorsePower
        End Get
    End Property
End Class

Class plane : Inherits Vehicle
    Dim inWingSpan As Integer

    Public Property WingSpan As Integer
        Set(value As Integer)
            inWingSpan = value
        End Set
        Get
            Return inWingSpan
        End Get
    End Property
End Class

Class waterVehicle : Inherits Vehicle
    Dim stHullMaterial As String
    Public Sub New()

    End Sub

    Public Sub New(VehicleName As String)
        MyBase.New(VehicleName)
    End Sub

    Public Sub New(VehicleName As String, VehicleType As String)
        MyBase.New(VehicleName, VehicleType)
    End Sub

    Public Property HullMaterial As String
        Set(value As String)
            stHullMaterial = value
        End Set
        Get
            Return stHullMaterial
        End Get
    End Property
End Class
