const base = {
    get() {
        return {
            url : "http://localhost:8080/net97irnin0/",
            name: "net97irnin0",
            // 退出到首页链接
            indexUrl: 'http://localhost:8080/net97irnin0/front/dist/index.html'
        };
    },
    getProjectName(){
        return {
            projectName: "鲜花销售系统"
        } 
    }
}
export default base
