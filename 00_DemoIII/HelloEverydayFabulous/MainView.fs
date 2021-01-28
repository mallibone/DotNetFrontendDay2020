namespace HelloEverydayFabulous

open Fabulous.XamarinForms
open Xamarin.Forms

module MainView =
    type Model = 
      { Count: int
        Step: int
        TimerOn: bool }


    type Msg = 
        | Increment 
        | Decrement 
        | Reset
        | SetStep of int
        | TimerToggled of bool
        | TimedTick

    let initModel = { Count = 0; Step = 1; TimerOn=false }

    let view (model: Model) dispatch =
        View.ContentPage(content = 
            View.StackLayout(padding = Thickness 20.0, verticalOptions = LayoutOptions.Center,
                children = [
                    View.Button(text = "Blue Page", command = (fun () -> dispatch (NavigateToColorView Color.Blue)), horizontalOptions = LayoutOptions.Center)
                ])
                )
