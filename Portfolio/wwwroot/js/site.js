window.initSkillsChart = function () {
    var ctx = document.getElementById("skillsChart")?.getContext("2d");
    if (!ctx) {
        console.error("Canvas element not found!");
        return;
    }

    new Chart(ctx, {
        type: "doughnut",
        data: {
            labels: ["Castle Climbers", "Girls Who Walk", "Bucket Connect"],
            datasets: [{
                data: [184, 68, 154], // Percentage values
                backgroundColor: ["#911F1F", "#F8846A", "#44D9C7"]
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            cutout: "50%", // Controls the size of the inner hole
            plugins: {
                legend: {
                    display: false
                },
                tooltip: {
                    enabled: true
                }
            }
        },
        plugins: [
            {
                id: "centerText",
                beforeDraw: function (chart) {
                    var width = chart.width,
                        height = chart.height,
                        ctx = chart.ctx;

                    ctx.restore();
                    var fontSize = (height / 10).toFixed(2); // Adjust text size
                    ctx.font = fontSize + "px sans-serif";
                    ctx.textBaseline = "middle";
                    ctx.textAlign = "center";

                    var text = "406",
                        textX = width / 2,
                        textY = height / 2;

                    ctx.fillStyle = "#000"; // Text color
                    ctx.fillText(text, textX, textY);
                    ctx.save();
                }
            }
        ]
    });
};
