module App

open Browser.Dom

let plus = document.getElementById "plus"
let minus = document.getElementById "minus"
let text = document.getElementById "counter"

let mutable count = 0

text.innerHTML <- (string count)

plus.addEventListener
    ("click", 
    fun _ -> count <- count + 1
             text.innerHTML <- (string count))

minus.addEventListener
    ("click", 
    fun _ -> count <- count - 1
             text.innerHTML <- (string count))