<?php

// This file has been auto-generated by the Symfony Dependency Injection Component for internal use.

if (\class_exists(\ContainerSpyqqd8\appDevDebugProjectContainer::class, false)) {
    // no-op
} elseif (!include __DIR__.'/ContainerSpyqqd8/appDevDebugProjectContainer.php') {
    touch(__DIR__.'/ContainerSpyqqd8.legacy');

    return;
}

if (!\class_exists(appDevDebugProjectContainer::class, false)) {
    \class_alias(\ContainerSpyqqd8\appDevDebugProjectContainer::class, appDevDebugProjectContainer::class, false);
}

return new \ContainerSpyqqd8\appDevDebugProjectContainer(array(
    'container.build_hash' => 'Spyqqd8',
    'container.build_id' => 'db0ed73f',
    'container.build_time' => 1534059410,
), __DIR__.\DIRECTORY_SEPARATOR.'ContainerSpyqqd8');