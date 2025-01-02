let resizeCallback = null;

export function GetInnerHeight() {
    return window.innerHeight;
}

export function GetInnerWidth() {
    return window.innerWidth;
}

export function RegisterResizeCallback(dotnetHelper) {
    resizeCallback = () => {
        const width = window.innerWidth;
        const height = window.innerHeight;
        dotnetHelper.invokeMethodAsync('OnResize', width, height);
    };
    window.addEventListener('resize', resizeCallback);
}

export function UnRegisterResizeCallback() {
    if (resizeCallback) {
        window.removeEventListener('resize', resizeCallback);
        resizeCallback = null;
    }
}
