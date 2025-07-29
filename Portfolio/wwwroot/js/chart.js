window.renderChart = function (climbers, bucket, girls) {
    const ctx = document.getElementById('firebaseChart')?.getContext('2d');
    if (!ctx) {
        console.error("Canvas not found");
        return;
    }

    new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: ['Castle Climbers', 'Bucket Connect', 'Girls Who Walk'],
            datasets: [{
                data: [climbers, bucket, girls],
                backgroundColor: ['#911f1f', '#41d5c3', '#eda193'],
                borderWidth: 0
            }]
        },
        options: {
            cutout: '65%',
            plugins: {
                legend: { display: false }
            }
        }
    });
};
