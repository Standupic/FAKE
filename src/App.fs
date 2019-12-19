module App

open Fable.React
open Fable.React.Props

type Model = 
  {
    Count : int
  }

type Msg = 
  | Increment
  | Decrement

let init () : Model = 
  {
    Count = 42
  }

let update msg model : Model = 
    match msg with
    |   Increment -> 
            {model with Count = model.Count + 1}
        
    |   Decrement ->
            {model with Count = model.Count - 1}

let view model dispatch = 
    div []
     [
         button [ OnClick (fun ev -> dispatch Decrement) ] [str "Минус"]
         h1 [] [ ofInt model.Count ]
         button [ OnClick (fun ev -> dispatch Increment)] [str "Плюс"]
     ]

open Elmish
open Elmish.React

Program.mkSimple init update view
|> Program.withReactSynchronous "app"
|> Program.run