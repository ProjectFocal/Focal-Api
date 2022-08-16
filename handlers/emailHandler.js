const nodemailer = require("nodemailer");
const dotenv = require('dotenv').config();
const fs = require('fs');
const path = require('path');
const { promisify } = require('util');
const readFile = promisify(fs.readFile);

exports.sendEmail = async (to, subject, htmlPath) => {
    return new Promise(async (resolve, reject) => {
        try {
            var transporter = nodemailer.createTransport({
                service: 'gmail',
                auth: {
                    user: "noreply.projectfocal@gmail.com",
                    pass: "xyrltwfjinalzruw"
                }
            });
              
            var mailOptions = {
                from: "",
                to: to,
                subject: subject,
                html: await readFile(htmlPath, 'utf8')
            };
              
            const result = await transporter.sendMail(mailOptions);
            resolve(result)
        }
        catch(err) {
            reject(err);
        }
    })
}