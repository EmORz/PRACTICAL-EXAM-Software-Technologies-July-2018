const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    // TODO:

    const Issue = sequelize.define("Issue", {
        title: {
            type: Sequelize.TEXT,
            allowNull: false,
        },
        content: {
            type: Sequelize.TEXT,
            allowNull: false,
        },
        priority:{
            type: Sequelize.INTEGER,
            allowNull: false,
        }
    }, {
        timestamps: false
    });

    return Issue;

};