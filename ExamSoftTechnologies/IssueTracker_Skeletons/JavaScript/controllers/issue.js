const Issue = require('../models').Issue;

module.exports = {
    index: (req, res) => {
       // TODO:
        let issues = Issue.findAll().then(issues  => {
            res.render('issue/index', {'issues': issues})
        });
    },
	
    createGet: (req, res) => {
        // TODO:
        res.render('issue/create');
    },
	
    createPost: (req, res) => {
       // TODO:
        let arg = req.body.issue;
        Issue.create(arg).then(()=> {
            return res.redirect("/");
        })

    },
	
    editGet: (req, res) => {
        // TODO:
        let id = req.params.id;
        Issue.findById(id).then(issue => {
            res.render('issue/edit', {'issue': issue})
        })
    },

    editPost: (req, res) => {
        // TODO:
        let id =req.params.id;
        let args = req.body.issue;
        Issue.findById(id).then( issue =>{
            issue.updateAttributes(args).then(() => {
                res.redirect('/')
            })
        })
    },

    deleteGet: (req, res) => {
        // TODO:
        let id =req.params.id;
        Issue.findById(id).then( issue =>{
            res.render('issue/delete', {'issue': issue});
        })
    },
	
    deletePost: (req, res) => {
        // TODO:
        let id =req.params.id;
        Issue.findById(id).then( issue =>{
            issue.destroy().then(() => {
                res.redirect('/')
            })
        })
    }
};