var path = require("path");

module.exports = {
    mode: "none",
    entry: "./src/App.fsproj",
    output: {
        path: path.join(__dirname, "./dist"),
        filename: "bundle.js"
    },
    devServer: {
        contentBase: path.join(__dirname, "./dist"),
        port: 8080
    },
    module: {
        rules: [{
            test: /\.fs(x|proj)?$/,
            use: "fable-loader"
        },
        {
            test: /\.css$/,
            use: ['style-loader','css-loader'],
        }]
    }
}