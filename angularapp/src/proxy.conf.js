const PROXY_CONFIG = [
  {
    context: [
      "/RInstatForm",
      "/RInstatForm/allforms",
      "/RInstatForm/rscript"
    ],
  //  "/RInstatForm/*": {
      target: "https://localhost:7238",
      //  target: "https://192.168.1.100:7238",
      secure: false,
    //  pathRewrite: { "^ /RInstatForm": "" },
    //  changeOrigin: true,
  //  }
  }
]

module.exports = PROXY_CONFIG;


//module.exports = {
//  //...
//  devServer: {
//    proxy: {
//      '/RInstatForm': {
//        target: 'http://localhost:7238',
//        pathRewrite: { '^/RInstatForm': '' },
//      },
//    },
//  },
//};
